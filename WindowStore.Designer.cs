namespace TheMerchShopGui {
    partial class WindowStore {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TitleUsername = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.ProductListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShoppingCart = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.quantityButton = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.ProductPriceLable = new System.Windows.Forms.Label();
            this.ProductPriceOutput = new System.Windows.Forms.Label();
            this.CustomerTotalPrice = new System.Windows.Forms.Label();
            this.CustomerTotalPriceLable = new System.Windows.Forms.Label();
            this.MyAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductInventoryCountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleUsername
            // 
            this.TitleUsername.AutoSize = true;
            this.TitleUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleUsername.Location = new System.Drawing.Point(427, 9);
            this.TitleUsername.Name = "TitleUsername";
            this.TitleUsername.Size = new System.Drawing.Size(320, 40);
            this.TitleUsername.TabIndex = 0;
            this.TitleUsername.Text = "Username\'s Store";
            this.TitleUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 20;
            this.ProductList.Location = new System.Drawing.Point(26, 96);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(280, 284);
            this.ProductList.TabIndex = 1;
            this.ProductList.Click += new System.EventHandler(this.OnItemSelect);
            // 
            // ProductListLabel
            // 
            this.ProductListLabel.AutoSize = true;
            this.ProductListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListLabel.Location = new System.Drawing.Point(22, 67);
            this.ProductListLabel.Name = "ProductListLabel";
            this.ProductListLabel.Size = new System.Drawing.Size(120, 20);
            this.ProductListLabel.TabIndex = 2;
            this.ProductListLabel.Text = "Store\'s Merch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Cart";
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.FormattingEnabled = true;
            this.ShoppingCart.ItemHeight = 20;
            this.ShoppingCart.Location = new System.Drawing.Point(878, 96);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(280, 284);
            this.ShoppingCart.TabIndex = 3;
            this.ShoppingCart.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FomatCartListBox);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(565, 198);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(166, 80);
            this.AddToCartButton.TabIndex = 5;
            this.AddToCartButton.Text = "Add to cart >>";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddItemToCart);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckoutButton.Location = new System.Drawing.Point(878, 393);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(279, 47);
            this.CheckoutButton.TabIndex = 6;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.PurchaseCart);
            // 
            // quantityButton
            // 
            this.quantityButton.Location = new System.Drawing.Point(344, 261);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(95, 26);
            this.quantityButton.TabIndex = 7;
            this.quantityButton.ValueChanged += new System.EventHandler(this.CalculateTotalPrice);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(340, 228);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(108, 20);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Enter quantity";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Location = new System.Drawing.Point(448, 117);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(0, 20);
            this.productPrice.TabIndex = 9;
            // 
            // ProductPriceLable
            // 
            this.ProductPriceLable.AutoSize = true;
            this.ProductPriceLable.Location = new System.Drawing.Point(340, 154);
            this.ProductPriceLable.Name = "ProductPriceLable";
            this.ProductPriceLable.Size = new System.Drawing.Size(103, 20);
            this.ProductPriceLable.TabIndex = 10;
            this.ProductPriceLable.Text = "Product Price";
            // 
            // ProductPriceOutput
            // 
            this.ProductPriceOutput.AutoSize = true;
            this.ProductPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPriceOutput.Location = new System.Drawing.Point(344, 178);
            this.ProductPriceOutput.Name = "ProductPriceOutput";
            this.ProductPriceOutput.Size = new System.Drawing.Size(51, 22);
            this.ProductPriceOutput.TabIndex = 11;
            this.ProductPriceOutput.Text = "$0.00";
            // 
            // CustomerTotalPrice
            // 
            this.CustomerTotalPrice.AutoSize = true;
            this.CustomerTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerTotalPrice.Location = new System.Drawing.Point(344, 353);
            this.CustomerTotalPrice.Name = "CustomerTotalPrice";
            this.CustomerTotalPrice.Size = new System.Drawing.Size(51, 22);
            this.CustomerTotalPrice.TabIndex = 13;
            this.CustomerTotalPrice.Text = "$0.00";
            // 
            // CustomerTotalPriceLable
            // 
            this.CustomerTotalPriceLable.AutoSize = true;
            this.CustomerTotalPriceLable.Location = new System.Drawing.Point(340, 329);
            this.CustomerTotalPriceLable.Name = "CustomerTotalPriceLable";
            this.CustomerTotalPriceLable.Size = new System.Drawing.Size(83, 20);
            this.CustomerTotalPriceLable.TabIndex = 12;
            this.CustomerTotalPriceLable.Text = "Total Price";
            // 
            // MyAccountButton
            // 
            this.MyAccountButton.Location = new System.Drawing.Point(25, 395);
            this.MyAccountButton.Name = "MyAccountButton";
            this.MyAccountButton.Size = new System.Drawing.Size(280, 44);
            this.MyAccountButton.TabIndex = 14;
            this.MyAccountButton.Text = "Account Details";
            this.MyAccountButton.UseVisualStyleBackColor = true;
            this.MyAccountButton.Click += new System.EventHandler(this.LaunchAccountDetails);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product  Quantity Stock";
            // 
            // ProductInventoryCountLabel
            // 
            this.ProductInventoryCountLabel.AutoSize = true;
            this.ProductInventoryCountLabel.Location = new System.Drawing.Point(344, 122);
            this.ProductInventoryCountLabel.Name = "ProductInventoryCountLabel";
            this.ProductInventoryCountLabel.Size = new System.Drawing.Size(27, 30);
            this.ProductInventoryCountLabel.TabIndex = 16;
            this.ProductInventoryCountLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteCartItem_click);
            // 
            // WindowStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductInventoryCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyAccountButton);
            this.Controls.Add(this.CustomerTotalPrice);
            this.Controls.Add(this.CustomerTotalPriceLable);
            this.Controls.Add(this.ProductPriceOutput);
            this.Controls.Add(this.ProductPriceLable);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.ProductListLabel);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.TitleUsername);
            this.Name = "WindowStore";
            this.Text = "WindowStore";
            ((System.ComponentModel.ISupportInitialize)(this.quantityButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleUsername;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Label ProductListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ShoppingCart;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.NumericUpDown quantityButton;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label ProductPriceLable;
        private System.Windows.Forms.Label ProductPriceOutput;
        private System.Windows.Forms.Label CustomerTotalPrice;
        private System.Windows.Forms.Label CustomerTotalPriceLable;
        private System.Windows.Forms.Button MyAccountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductInventoryCountLabel;
        private System.Windows.Forms.Button button1;
    }
}