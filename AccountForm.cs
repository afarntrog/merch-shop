using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMerchShopGui {
    public partial class AccountForm : Form {
        // This will be the customer that is currently shopping.
        private Customer activeCustomer;

        public AccountForm() {
            InitializeComponent();
        }

        public AccountForm(Customer activeCustomer) {
            InitializeComponent();
            this.activeCustomer = activeCustomer;
            PopulateForm();
        }

        private void PopulateForm() {
            try {
                using (var db = new DataClasses1DataContext()) {
                    Account customerAccount = db.Accounts.Single(a => a.Customer == activeCustomer.Username);
                    BalanceLabel.Text = customerAccount.Debt.ToString();
                    cohLabel.Text = customerAccount.Cash.ToString();
                    PurchaseHistoryTotalLabel.Text = db.OrderItems.Where(oi => oi.Customer == activeCustomer.Username).Count().ToString(); // Get all order items that have an OrderID that are attached to this customer.
                }
            } catch {
                throw new InvalidOperationException("You do not have an account. Please contact support.");
            }
        }

        /* When use clicks to pay balance
         * launch the PayMethodFrom that gives the user an option of what to pay  with
         * get method of payment
         * apply payment for that method
         */
        private void PayBalance(object sender, EventArgs e) {

            // Payment method. default CC.
            string paymentMethod = PayMethodForm.CREDIT_CARD;

            using (var payMethodForm = new PayMethodForm()) {
                var formResult = payMethodForm.ShowDialog();
                if (formResult == DialogResult.OK) {
                    paymentMethod = payMethodForm.paymentMethod;
                }
            }

            if (paymentMethod == PayMethodForm.CREDIT_CARD) {
                PayWithCreditCard();
            } else {
                PayWithCashOnHand();
            }
            UpdateLabelInfo();
        }


        // This updates the labels after a transaction
        private void UpdateLabelInfo() {
            PopulateForm();
        }

        private void PayWithCashOnHand() {
            using (var creditCardPaymentForm = new CashOnHandPaymentForm(activeCustomer)) {
                var formResult = creditCardPaymentForm.ShowDialog();
                DisplayMessage(formResult);
            }
            UpdateLabelInfo();
        }


        /*
         * Launch credit card inputer.
         * Get amount from user
         * Deduct the amount paid from the debt owed,
         * If paid too much then you should send the overlfow into the Cashon hand.
         * Save payment in the database as Payment.
         * */
        private void PayWithCreditCard() {
            using (var creditCardPaymentForm = new CreditCardPaymentForm(activeCustomer)) {
                var formResult = creditCardPaymentForm.ShowDialog();
                DisplayMessage(formResult);
            }
        }

        // Display message to user about payment status.
        private static void DisplayMessage(DialogResult formResult) {
            if (formResult == DialogResult.OK) {
                MessageBox.Show("Congrats! Payment was a success");
            }
            else {
                MessageBox.Show(":( Payment failed. Contact support.");
            }
        }


        // User wants to add cash
        private void Addcoh_click(object sender, EventArgs e) {
            using (var addcohForm = new AddcohForm(activeCustomer)) {
                var formResult = addcohForm.ShowDialog();
            }
            UpdateLabelInfo();
        }


        //This is called when user clicks to view the purchase history
        private void PurchaseHistory_click(object sender, EventArgs e) {

            using (var purchaseHistoryForm = new PurchaseHistoryStart(activeCustomer)) {
                var formResult = purchaseHistoryForm.ShowDialog();
            }
        }
    }
}