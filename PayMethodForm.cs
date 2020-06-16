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

    /*
     * This class will get the method of payment the user wishes to use to pay off his balance.
     * 
     * */
    public partial class PayMethodForm : Form {


        // Strings to hold the method of payment name for consistency/enum.
        public readonly static string CREDIT_CARD = "CC";
        public readonly static string CASH_ON_HAND = "COH";


        public string paymentMethod { get; private set; } = "";
        public PayMethodForm() {
            InitializeComponent();
        }


        // When the user clicks to pay with cc
        private void PayWithCreditCard(object sender, EventArgs e) {
            this.paymentMethod = CREDIT_CARD;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        // When the user clicks to pay with Cash on hand
        private void PayWithCashOnHand(object sender, EventArgs e) {
            this.paymentMethod = CASH_ON_HAND;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
