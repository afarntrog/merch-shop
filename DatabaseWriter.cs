using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMerchShopGui {
    public static class DatabaseWriter {

        // This will write the payment to the database.
        public static void WritePaymentToDB(decimal amountPaid, Customer activeCustomer, int method) {
            using (var db = new DataClasses1DataContext()) {
                Payment payment = new Payment() {
                    Customer = activeCustomer.Username,
                    Method = method,
                    Amount = amountPaid,
                    DatePaid = DateTime.Now
                };
                db.Payments.InsertOnSubmit(payment);
                db.SubmitChanges();
            }
        }
    
    }
}
