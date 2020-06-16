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
    public partial class CashOnHandPaymentForm : Form {

        // This will be the customer that is currently shopping.
        private Customer activeCustomer;
        public CashOnHandPaymentForm() {
            InitializeComponent();
        }

        public CashOnHandPaymentForm(Customer activeCustomer) {
            InitializeComponent();
            this.activeCustomer = activeCustomer;   // Set active customer
            SetupLabels(activeCustomer);
        }

        private void SetupLabels(Customer activeCustomer) {
            AmountBeingPayedUpDown.Maximum = activeCustomer.Accounts.Single(a => a.Customer == activeCustomer.Username).Cash;   // set the max amount of up down button to amount of cashonhand
            AmountOwedLabel.Text = $"You have a balance of: ${ activeCustomer.Accounts.Where(a => a.Customer == activeCustomer.Username).Select(a => a.Debt).FirstOrDefault().ToString()}";
            CustomerCOHamountLabel.Text = $"Your Cash-On-Hand amount is: ${ activeCustomer.Accounts.Where(a => a.Customer == activeCustomer.Username).Select(a => a.Cash).FirstOrDefault().ToString()}";
        }

        private void PayWithCOH_click(object sender, EventArgs e) {
            decimal amountPaid = AmountBeingPayedUpDown.Value;
            DatabaseWriter.WritePaymentToDB(amountPaid, activeCustomer, 2);

            DeductDebtAccordingly(amountPaid);

            // Close this form after customer submits payment details.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void DeductDebtAccordingly(decimal amountPaid) {
            try {
                // Deduct debt and handle overflow
                using (var db = new DataClasses1DataContext()) {
                    Account account = db.Accounts.Single(a => a.Customer == activeCustomer.Username);

                    if (amountPaid > account.Cash) {
                        MessageBox.Show("Payment unsuccessfull. You cannot pay with more money then you have.");
                        return;
                    }
                    else if (amountPaid > account.Debt) {
                        account.Cash += (amountPaid - account.Debt);
                        account.Debt = 0;
                    }
                    else {
                        account.Debt -= amountPaid;
                        account.Cash -= amountPaid; // money came from cash.
                    }
                    db.SubmitChanges();
                }
            }

            catch (InvalidOperationException h) {
                MessageBox.Show("We couldn't find an account for you. Please contact customer support.");
            }
        }
    }
}
