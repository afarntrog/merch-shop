using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMerchShopGui {
    public partial class PurchaseHistoryStart : Form {
        readonly Customer activeCustomer;
    public PurchaseHistoryStart(Customer activeCustomer) {
            InitializeComponent();
            this.activeCustomer = activeCustomer;
            SetupDataGrid();
            DisplayPurchaseHistory();
        }


        // Format column to be currency
        private void SetupDataGrid() {
            PurchaseHistoryDataGridDesign.Columns[2].DefaultCellStyle.Format = "c";
        }

        public void DisplayPurchaseHistory() {
            DisplayPurchaseHistory((d) => true, (p) => true);
        }

        // This will populate the datagrid  with the correct purchase history and handle all the filters.
        public void DisplayPurchaseHistory(Func<DateTime, bool> WithinDateRange, Func<decimal, bool> WithinPriceRange) {
            // Set table to empty.
            PurchaseHistoryDataGridDesign.Rows.Clear();

            // Get all the purchase orders for this customer
            using (var db = new DataClasses1DataContext()) {
                var purchaseHistory = db.PurchaseOrders.Where(cust => cust.Customer == activeCustomer.Username)
                                              .Join(db.OrderItems, po => po.OrderID, oi => oi.PurchaseOrder,
                                                    (PurchaseOrderTable, OrderItemTable) => new { PurchaseOrderTable, OrderItemTable })
                                              .AsEnumerable();

                // Add a row for each  purchase info
                foreach (var purchase in purchaseHistory.Where(ph => WithinDateRange(ph.PurchaseOrderTable.OrderedDate) && WithinPriceRange(ph.OrderItemTable.Product.Price * ph.OrderItemTable.Quantity))) {//.Where(ph => true //WithinDateRange( ph.PurchaseOrderTable.OrderedDate.Date ) && WithinPriceRange(ph.OrderItemTable.Product.Price * ph.OrderItemTable.Quantity)
                    PurchaseHistoryDataGridDesign.Rows.Add(purchase.OrderItemTable.Product.Name,
                                                           purchase.OrderItemTable.Quantity,
                                                           (purchase.OrderItemTable.Product.Price * purchase.OrderItemTable.Quantity),
                                                           purchase.PurchaseOrderTable.OrderedDate
                                                           );
                }
            }
        }

        private void FilterDateHistory_click(object sender, EventArgs e) {
            DisplayPurchaseHistory((d) => d >= dateTimePickerStart.Value && d <= dateTimePickerEnd.Value,
                                   (p) => true);
        }

        private void FilterByPrice_click(object sender, EventArgs e) {
            DisplayPurchaseHistory((d) => true, (p) => p >= PriceRangeStart.Value && p <= PriceRangeEnd.Value);
        }

        private void FilterByPriceAndDate_click(object sender, EventArgs e) {
            DisplayPurchaseHistory((d) => d >= dateTimePickerStart.Value && d <= dateTimePickerEnd.Value,
                                   (p) => p >= PriceRangeStart.Value && p <= PriceRangeEnd.Value);
        }

        private void ClearFilters_click(object sender, EventArgs e) {
            DisplayPurchaseHistory((d) => true, (p) => true);
        }
    }
}
