using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * I used inheritence too  override the the parent classes of the cc form.
 
     */
namespace TheMerchShopGui {
    public partial class AddcohForm : CreditCardPaymentForm {
        private Customer activeCustomer;
        public AddcohForm(Customer activeCustomer) : base() {
            PopulateForm();
            this.activeCustomer = activeCustomer;
        }


        // Override the parent labels.
        private void PopulateForm() {
            AmountOwedLabelPublic = "";
            TitleLabelPublic = "Add money to Cash-On-Hand";
            PayWithCCButtonPublic = "Add now";
            AmountBeingPayedLabelPublic = "Amount you want to add: ";
        }


        // Get users account
        // add amount of cash to the users account
        public override void CompletePaymentWithCC(object sender, EventArgs e) {
            using (var db = new DataClasses1DataContext()) {
                Account account = db.Accounts.Where(a => a.Customer == this.activeCustomer.Username).FirstOrDefault();
                if (account != null) {
                    account.Cash += AmountBeingPayedUpDownPublic;
                    db.SubmitChanges();
                }
            }
            // leave
            this.Close();
        }
    }
}
