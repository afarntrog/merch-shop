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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // DELETE auto login
            loginUsername.Text = "aaron2";
            loginPassword.Text = "123";
        }

        private void loginButton(object sender, EventArgs e) {
            // Get login credentials
            string username = loginUsername.Text;
            string password = loginPassword.Text;

            // Get current user
            using (var db = new DataClasses1DataContext()) {
                var loginUser = db.Customers.Where(c => c.Username == username && c.Password == password).FirstOrDefault();
                if (loginUser != null) {
                    LaunchStore(loginUser);
                }
                else {
                    // TODO add separate message saying. Username exists but no matching password.
                    errorMessage.Text = "Invalid username or password.";
                }
            };
            // loginUsername.Clear();
        }

        private void signupButton(object sender, EventArgs e) {
            // Get username
            string username = signupUsername.Text;
            string password = signupPassword.Text;

            // Create the new user if valid
            using (var db = new DataClasses1DataContext()) {
                // Check if this username exists and make sure password is not empty
                if (!db.Customers.Any(c => c.Username == username) && password.Length > 0) {
                    var newCustomer = new Customer() { Username = username, Password = password, SignedUpDate = DateTime.Now };
                    // Queue it to db
                    db.Customers.InsertOnSubmit(newCustomer);
                    // actually write it to db
                    db.SubmitChanges();


                    // Close the signin window and open the store.
                    LaunchStore(newCustomer);
                }
                else {
                    // Display error message user the username is taken
                    errorMessage.Text = "Username is taken. Please try another one.";
                }
            };
        }

        private void LaunchStore(Customer newCustomer) {
            this.Hide();
            // NOTE : I would extract this to a method and the store should say Username's Account
            WindowStore store = new WindowStore(newCustomer);
            store.ShowDialog();
            this.Close();
        }




    }
}
