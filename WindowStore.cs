using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMerchShopGui {
    public partial class WindowStore : Form {

        // Max amount of money can owe, however one purchase can surpass this, but cannot make purchase if owe more than this.
        public static readonly int CREDIT_LIMIT = 1000;


        // This will be the customer that is currently shopping.
        private Customer activeCustomer;

        // Connect the products to the Product list box
        BindingSource productsBinding = new BindingSource();

        // Connect the products to the Shopping cart
        BindingSource cartBinding = new BindingSource();
        public WindowStore() {
            InitializeComponent();
        }


        public WindowStore(Customer activeCustomer) {
            InitializeComponent();
            this.activeCustomer = activeCustomer;

            // setup title
            TitleUsername.Text = $"{activeCustomer.Username}'s store";

            // PopulateStore
            PopulateStore();
        }


        // Populate the store with products and info
        private void PopulateStore() {
            PopulateProductList();
            PopulateCartList();
        }

        // populate the product listing section.
        private void PopulateProductList() {
            using (var db = new DataClasses1DataContext()) {
                var items = db.Products.Where(p => true); //db.Customers.Where(c => true).ToList();
                productsBinding.DataSource = items;
                ProductList.DataSource = productsBinding;

                // Values and text to be displayed in the listbox
                ProductList.DisplayMember = "Name";
                ProductList.ValueMember = "SKU";
            }
        }

        // Populate the shopping cart
        private void PopulateCartList() {
            List<CartItem> items = GetCustomerCartItems();

            // shopping cart products for this  user. and remember to display how many items are for this user.
            if (items != null) {
                cartBinding.DataSource = items;
                ShoppingCart.DataSource = cartBinding;

                // Values and text to be displayed in the listbox
                ShoppingCart.DisplayMember = "Name";
                ShoppingCart.ValueMember = "SKU";
            }
        }

        // Get  the customers shopping cart items.
        private List<CartItem> GetCustomerCartItems() {
            using (var db = new DataClasses1DataContext()) {
                // Get users shopping Cart.
                CustomerCart customerCart = db.CustomerCarts.Where(c => c.Customer == activeCustomer.Username).FirstOrDefault();
                // Get all items in this cart

                return db.CartItems.Where(item => item.CustomerCart == customerCart.CustomerCartID).ToList();
            }
        }


        // Add the item to customers cart, in SQL
        private void AddItemToCart(object sender, EventArgs e) {
            // Get selected item.
            Product selectedItem = (Product)ProductList.SelectedItem;
            // Get the quantity of the item. and make sure it is > 0
            int productQuantity = (int)quantityButton.Value;

            // make sure it is > 0 quantity and the inventory is greater than 0
            if (!CanBeAddedToCart(selectedItem, productQuantity)) { return; }

            // add it to the shopping cart by updating our shopping cart database
            using (var db = new DataClasses1DataContext()) {
                CustomerCart customerCart = db.CustomerCarts.Where(c => c.Customer == activeCustomer.Username).FirstOrDefault();
                if (customerCart != null) {

                    // If the item is already in the cart then UPDATE it rather then create a new entry.
                    CartItem cartItem = db.CartItems.Where(item => item.CustomerCart == customerCart.CustomerCartID && item.SKU == selectedItem.SKU).FirstOrDefault();
                    if (cartItem != null) {
                        cartItem.Quantity += productQuantity;
                    } else {
                        // Create a new Entry for CartItem for this customer.
                        CartItem newCartItem = new CartItem() {
                            CustomerCart = (customerCart).CustomerCartID,
                            SKU = selectedItem.SKU,
                            Quantity = productQuantity,
                            DateAdded = DateTime.Now
                        };
                        // Write items to db
                        db.CartItems.InsertOnSubmit(newCartItem);
                    }
                    db.SubmitChanges();

                    // Update the shopping cart
                    PopulateCartList();
                }
                else {
                    MessageBox.Show("You don't have a cart. Please contact us.");
                }

            };
        }

        // Validates if item can be added to cart.
        private bool CanBeAddedToCart(Product selectedItem, int productQuantity) {
            using (var db = new DataClasses1DataContext()) {
                if (db.Inventories.Where(c => c.SKU == selectedItem.SKU).Select(c => c.Quantity).FirstOrDefault() < 1) {
                    MessageBox.Show("You cannot add a product that has 0 inventory in stock.");
                    return false;
                }
            }
            // make sure it is > 0
            if (productQuantity < 1) {
                MessageBox.Show("You cannot add 0 quantity to your cart.");
                return false;
            }
            return true;
        }


        // When the user increments the quantity then you should increment the total price.
        private void CalculateTotalPrice(object sender, EventArgs e) {
            decimal total = ((Product)ProductList.SelectedItem).Price * quantityButton.Value;
            CustomerTotalPrice.Text = $"${total}";
        }


        // When  an item is selected then display it's price and set quantity to 0
        private void OnItemSelect(object sender, EventArgs e) {
            Product selectedItem = ((Product)ProductList.SelectedItem);
            int selectedItemInventoryCount = GetProductInventoryCount(selectedItem);
            SetupUpDownButton(selectedItemInventoryCount);
            SetupLabels(selectedItem, selectedItemInventoryCount);
        }


        // Setup the  labels when user selects an item
        private void SetupLabels(Product selectedItem, int selectedItemInventoryCount) {
            // get and set the item price label.
            ProductPriceOutput.Text = $"${selectedItem.Price}";
            // set the product ineventory count label.
            ProductInventoryCountLabel.Text = selectedItemInventoryCount.ToString();
        }

        // setup product amount buttons when user selects an item
        private void SetupUpDownButton(int selectedItemInventoryCount) {
            // first set the  quantity to 1
            quantityButton.Value = 0;
            // Then set the Max value to the inventory stock amount
            quantityButton.Maximum = selectedItemInventoryCount;
        }

        private int GetProductInventoryCount(Product selectedItem) {
            // Show user the amount of stock in inventory
            using (var db = new DataClasses1DataContext()) {
                return db.Inventories.Where(i => i.SKU == selectedItem.SKU).Select(i => i.Quantity).FirstOrDefault();
            }
        }


        // This will format the list box to display multiple items.
        private void FomatCartListBox(object sender, ListControlConvertEventArgs e) {
            string productName;
            using (var db = new DataClasses1DataContext()) {
                productName = db.CartItems.Where(item => item.SKU == ((CartItem)e.ListItem).SKU).Select(item => item.Product.Name).FirstOrDefault();
            }
            e.Value = $"{((CartItem)e.ListItem).Quantity.ToString()} - {productName}";
        }



        // When the user checks out the cart purchases this is called.
        private void PurchaseCart(object sender, EventArgs e) {
            // If user owes more than the limit then disable purchase.
            if (!(activeCustomer.Accounts.Select(a => a.Debt).First() > CREDIT_LIMIT)) {

                // Get cart items and record transactions
                using ( var db = new DataClasses1DataContext()) {
                    //  Get all the items in the cart
                    List<CartItem> allCartItems = GetAllCartItems(db); ;// = db.CustomerCarts.SelectMany(cart => cart.CartItems.Where(item => item.CustomerCart == cart.CustomerCartID)).ToList();
                    /// Think problem is with caching

                    // Update the inventory quantity
                    bool inventoryUpdateSuccess = UpdateInventoryQuantity(allCartItems, db);

                    // Do NOT proceed if the inventory does not Have all the items.
                    if (!inventoryUpdateSuccess) {
                        MessageBox.Show("Please remove some items from your cart. We do not have it in inventory.");
                        return;
                    }

                    // Create a PurchaseOrder and write it to  the Databse.
                    var purchaseOrder = new PurchaseOrder() { Customer = activeCustomer.Username, OrderedDate = DateTime.Now };
                    WriteRowsToDB(new List<PurchaseOrder>() { purchaseOrder });

                    // for each item in the cart create a OrderItem
                    WriteOrderItemToDB(allCartItems, purchaseOrder.OrderID);

                    // Add total to debt
                    AddPurchaseTotalToDebt(db, allCartItems);

                    // Wipe the shopping cart. By deleting all the cart items that match the orderItems.
                    DeleteItemsInCart(allCartItems);
                }

                // var allCartItems = activeCustomer.CustomerCarts.SelectMany(cart => cart.CartItems.Where(item => item.CustomerCart == cart.CustomerCartID)).ToList();

            }
            else {
                MessageBox.Show("You cannot purchase since your Debt is greater then the limit of: " + CREDIT_LIMIT);
            }

        }

        // Will add the purchase total to the  debt.
        // Must do quantity * price to get total from each  item
        private void AddPurchaseTotalToDebt(DataClasses1DataContext db, List<CartItem> allCartItems) {
            // Deduct the amount of money from the customers Debt , or rather add the cart total to the debt
            // Using LINQ for this saved me an entire method. Cool.
            Account account = db.Accounts.Where(a => a.Customer == activeCustomer.Username).FirstOrDefault();
            if (account != null) {
                account.Debt += allCartItems.Sum(item => item.Product.Price * item.Quantity);
                db.SubmitChanges();
            }
        }

        // Return a list of all the customers cart items.
        private List<CartItem> GetAllCartItems(DataClasses1DataContext db) {
            List<CartItem> allCartItems = null;
            try {
                int cartID = db.CustomerCarts.Where(c => c.Customer == activeCustomer.Username).Select(c => c.CustomerCartID).First();
                allCartItems = db.CartItems.Where(item => item.CustomerCart == cartID).ToList();
            }
            catch (Exception) {
                MessageBox.Show("ERROR: You don't have a cart. Contact support.");
            }

            return allCartItems;
        }


        // Update the inventory because user bought n quantity of item x.
        // Returns boolean if all the items can be succussfully 'taken' from inventory
        // If one item cannot be successfully taken from the invventoyr then the entire order will go unfulfilled
        // use should  edit his cart if he still wants items.
        private bool UpdateInventoryQuantity(IEnumerable<CartItem> allCartItems, DataClasses1DataContext db) {
            foreach (CartItem item in allCartItems) {
                Inventory inventory = db.Inventories.Where(i => i.SKU == item.SKU).FirstOrDefault(); // item.Product.Inventories.Where(i => i.SKU == item.SKU).FirstOrDefault();
                if (inventory != default(Inventory)) {
                    // update the inventory only if the purchase quantity is NOT more than the inventory  amount
                    if (item.Quantity <= inventory.Quantity) {
                        inventory.Quantity -= item.Quantity;
                    }
                    else
                        return false;   // do not add it and return
                }
                else {
                    MessageBox.Show("There is no inventory for that product. Sorry");
                    return false;
                }
            }
            // Submit the inventory changes and then return.
            db.SubmitChanges();
            return true;
        }



        // Delete cart items.
        private void DeleteItemsInCart(List<CartItem> allCartItems) {
            using (var db = new DataClasses1DataContext()) {
                foreach (CartItem item in allCartItems) {
                    db.CartItems.DeleteOnSubmit(db.CartItems.Single(i => i.CartItemID == item.CartItemID));                    
                }
                db.SubmitChanges();
            }
            // Populate the cartlist (should have no elements) InvalidOperationException
            PopulateCartList();
        }

        // Writes all the cartitems to database as purchase.
        private void WriteOrderItemToDB(IEnumerable<CartItem> allCartItems, int purchaseOrderID) {
            
            // Generate a List of OrderItems from all the items in the cart.
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (CartItem item in allCartItems) {
                var item1 = new OrderItem() {
                    Customer = activeCustomer.Username,
                    SKU = item.SKU,
                    PurchaseOrder = purchaseOrderID,
                    Quantity = item.Quantity
                };
                orderItems.Add(item1);
            }
            // Write the new items to db
            WriteRowsToDB(orderItems);
        }

        private void WriteRowsToDB<T>(List<T> orderItemsInput) {
            using (var db = new DataClasses1DataContext()) {
                if (typeof(T) == typeof(OrderItem) ) {
                    orderItemsInput.ToList().ForEach(item => db.OrderItems.InsertOnSubmit(item as OrderItem));
                    // db.OrderItems.InsertAllOnSubmit(orderItems);
                 }
                else if (typeof(T) == typeof(PurchaseOrder)) {
                    orderItemsInput.ToList().ForEach(item => db.PurchaseOrders.InsertOnSubmit(item as PurchaseOrder));
                }
                db.SubmitChanges();
            }
        }



        // Launch the account details form.
        private void LaunchAccountDetails(object sender, EventArgs e) {
            this.Hide();
            AccountForm accountForm = new AccountForm(activeCustomer);
            accountForm.ShowDialog();
            this.Refresh();
            this.Show();
        }


        // Delete any single cart item.
        private void DeleteCartItem_click(object sender, EventArgs e) {
            // Re-use my other method that deleted all items in Cart after checkout.
            CartItem cartItem = ((CartItem)ShoppingCart.SelectedItem);
            if (cartItem != null)
                DeleteItemsInCart(new List<CartItem> { cartItem });
            else
                MessageBox.Show("You must select an item to delete");
            // TODO allow user to edit the amount they want to delete.
        }


    }
}
