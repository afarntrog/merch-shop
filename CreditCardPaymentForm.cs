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
    public partial class CreditCardPaymentForm : Form {

        // This will be the customer that is currently shopping.
        protected Customer activeCustomer;


        public CreditCardPaymentForm() {
            InitializeComponent();
        }

        public CreditCardPaymentForm(Customer customer) {
            InitializeComponent();
            this.activeCustomer = customer;
            SetupLables();
        }

        private void SetupLables() {
            AmountBeingPayedUpDown.Maximum = Decimal.MaxValue;
            AmountOwedLabel.Text = $"You have a balance of: ${ activeCustomer.Accounts.Where(a => a.Customer == activeCustomer.Username).Select(a => a.Debt).FirstOrDefault().ToString()}";
        }

        /*
         * Create new payment row and save to db
         * Deduct payment.
         */
        public virtual void CompletePaymentWithCC(object sender, EventArgs e) {
            decimal amountPaid = AmountBeingPayedUpDown.Value;

            DatabaseWriter.WritePaymentToDB(amountPaid, activeCustomer, 1);

            DeductDebtAccordingly(amountPaid);
            MessageBox.Show("HEEREE");

            // Close this form after customer submits payment details.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /* 
         * deduct debt accordingly
         * store extra money in cash-on-hand
         * Best to create this in a parent class and then just override it  in each  individual class/form.
         */
        public void DeductDebtAccordingly(decimal amountPaid) {
            try {
                using (var db = new DataClasses1DataContext()) {
                    // Deduct debt and handle overflow
                    Account account = db.Accounts.Single(a => a.Customer == activeCustomer.Username);

                    if (amountPaid > account.Debt) {
                        account.Cash += (amountPaid - account.Debt);
                        account.Debt = 0;
                    }
                    else {
                        account.Debt -= amountPaid;
                    }
                    db.SubmitChanges();
                }
            }
            catch (InvalidOperationException) {
                MessageBox.Show("We couldn't find an account for you. Please contact customer support.");
            }
        }

        //
        // EXPOSE all the fields to the world so children can use them
        //
        public string AmountOwedLabelPublic {
            get {
                return AmountOwedLabel.Text;
            }
            set {
                AmountOwedLabel.Text = value;
            }
        }
        public string PayWithCCButtonPublic {
            get {
                return PayWithCCButton.Text;
            }
            set {
                PayWithCCButton.Text = value;
            }
        }
        public string AmountBeingPayedLabelPublic {
            get {
                return AmountBeingPayedLabel.Text;
            }
            set {
                AmountBeingPayedLabel.Text = value;
            }
        }
        public string TitleLabelPublic {
            get {
                return TitleLabel.Text;
            }
            set {
                TitleLabel.Text = value;
            }
        }

        public decimal AmountBeingPayedUpDownPublic {
            get { return AmountBeingPayedUpDown.Value; }
        }
    }
}
