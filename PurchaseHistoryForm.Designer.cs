namespace TheMerchShopGui {
    partial class PurchaseHistoryStart {
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
            this.PurchaseHistoryLabel = new System.Windows.Forms.Label();
            this.PurchaseHistoryDataGridDesign = new System.Windows.Forms.DataGridView();
            this.ItemPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.FilterDateButton = new System.Windows.Forms.Button();
            this.ClearFiltersButtons = new System.Windows.Forms.Button();
            this.PriceRangeStart = new System.Windows.Forms.NumericUpDown();
            this.PriceRangeEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterByPrice = new System.Windows.Forms.Button();
            this.FilterByPriceAndDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDataGridDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseHistoryLabel
            // 
            this.PurchaseHistoryLabel.AutoSize = true;
            this.PurchaseHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseHistoryLabel.Location = new System.Drawing.Point(12, 41);
            this.PurchaseHistoryLabel.Name = "PurchaseHistoryLabel";
            this.PurchaseHistoryLabel.Size = new System.Drawing.Size(332, 32);
            this.PurchaseHistoryLabel.TabIndex = 0;
            this.PurchaseHistoryLabel.Text = "Aaron\'s Purchase History";
            // 
            // PurchaseHistoryDataGridDesign
            // 
            this.PurchaseHistoryDataGridDesign.AllowUserToAddRows = false;
            this.PurchaseHistoryDataGridDesign.AllowUserToDeleteRows = false;
            this.PurchaseHistoryDataGridDesign.AllowUserToOrderColumns = true;
            this.PurchaseHistoryDataGridDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseHistoryDataGridDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemPurchased,
            this.PurchaseQuantity,
            this.PurchaseTotalPrice,
            this.PurchaseDate});
            this.PurchaseHistoryDataGridDesign.Location = new System.Drawing.Point(78, 195);
            this.PurchaseHistoryDataGridDesign.Name = "PurchaseHistoryDataGridDesign";
            this.PurchaseHistoryDataGridDesign.ReadOnly = true;
            this.PurchaseHistoryDataGridDesign.RowHeadersWidth = 62;
            this.PurchaseHistoryDataGridDesign.RowTemplate.Height = 28;
            this.PurchaseHistoryDataGridDesign.Size = new System.Drawing.Size(1237, 304);
            this.PurchaseHistoryDataGridDesign.TabIndex = 1;
            // 
            // ItemPurchased
            // 
            this.ItemPurchased.HeaderText = "Item Purchased";
            this.ItemPurchased.MinimumWidth = 8;
            this.ItemPurchased.Name = "ItemPurchased";
            this.ItemPurchased.ReadOnly = true;
            this.ItemPurchased.Width = 144;
            // 
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.HeaderText = "Purchase Quantity";
            this.PurchaseQuantity.MinimumWidth = 8;
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.ReadOnly = true;
            this.PurchaseQuantity.Width = 150;
            // 
            // PurchaseTotalPrice
            // 
            this.PurchaseTotalPrice.HeaderText = "Purchase Total";
            this.PurchaseTotalPrice.MinimumWidth = 8;
            this.PurchaseTotalPrice.Name = "PurchaseTotalPrice";
            this.PurchaseTotalPrice.ReadOnly = true;
            this.PurchaseTotalPrice.Width = 150;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.MinimumWidth = 8;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 150;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(850, 19);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(128, 26);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.Value = new System.DateTime(2020, 5, 26, 15, 51, 15, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(850, 79);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(128, 26);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Value = new System.DateTime(2020, 5, 26, 15, 51, 30, 0);
            // 
            // FilterDateButton
            // 
            this.FilterDateButton.Location = new System.Drawing.Point(1033, 17);
            this.FilterDateButton.Name = "FilterDateButton";
            this.FilterDateButton.Size = new System.Drawing.Size(104, 88);
            this.FilterDateButton.TabIndex = 4;
            this.FilterDateButton.Text = "Filter by Date";
            this.FilterDateButton.UseVisualStyleBackColor = true;
            this.FilterDateButton.Click += new System.EventHandler(this.FilterDateHistory_click);
            // 
            // ClearFiltersButtons
            // 
            this.ClearFiltersButtons.Location = new System.Drawing.Point(1353, 17);
            this.ClearFiltersButtons.Name = "ClearFiltersButtons";
            this.ClearFiltersButtons.Size = new System.Drawing.Size(103, 88);
            this.ClearFiltersButtons.TabIndex = 5;
            this.ClearFiltersButtons.Text = "Clear Filters";
            this.ClearFiltersButtons.UseVisualStyleBackColor = true;
            this.ClearFiltersButtons.Click += new System.EventHandler(this.ClearFilters_click);
            // 
            // PriceRangeStart
            // 
            this.PriceRangeStart.DecimalPlaces = 2;
            this.PriceRangeStart.Location = new System.Drawing.Point(452, 17);
            this.PriceRangeStart.Name = "PriceRangeStart";
            this.PriceRangeStart.Size = new System.Drawing.Size(77, 26);
            this.PriceRangeStart.TabIndex = 6;
            // 
            // PriceRangeEnd
            // 
            this.PriceRangeEnd.DecimalPlaces = 2;
            this.PriceRangeEnd.Location = new System.Drawing.Point(452, 77);
            this.PriceRangeEnd.Name = "PriceRangeEnd";
            this.PriceRangeEnd.Size = new System.Drawing.Size(77, 26);
            this.PriceRangeEnd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price end";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Range end";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Range start";
            // 
            // FilterByPrice
            // 
            this.FilterByPrice.Location = new System.Drawing.Point(569, 21);
            this.FilterByPrice.Name = "FilterByPrice";
            this.FilterByPrice.Size = new System.Drawing.Size(104, 88);
            this.FilterByPrice.TabIndex = 12;
            this.FilterByPrice.Text = "Filter by Price";
            this.FilterByPrice.UseVisualStyleBackColor = true;
            this.FilterByPrice.Click += new System.EventHandler(this.FilterByPrice_click);
            // 
            // FilterByPriceAndDate
            // 
            this.FilterByPriceAndDate.Location = new System.Drawing.Point(1202, 19);
            this.FilterByPriceAndDate.Name = "FilterByPriceAndDate";
            this.FilterByPriceAndDate.Size = new System.Drawing.Size(103, 88);
            this.FilterByPriceAndDate.TabIndex = 13;
            this.FilterByPriceAndDate.Text = "Filter by Price and Date";
            this.FilterByPriceAndDate.UseVisualStyleBackColor = true;
            this.FilterByPriceAndDate.Click += new System.EventHandler(this.FilterByPriceAndDate_click);
            // 
            // PurchaseHistoryStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 567);
            this.Controls.Add(this.FilterByPriceAndDate);
            this.Controls.Add(this.FilterByPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceRangeEnd);
            this.Controls.Add(this.PriceRangeStart);
            this.Controls.Add(this.ClearFiltersButtons);
            this.Controls.Add(this.FilterDateButton);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.PurchaseHistoryDataGridDesign);
            this.Controls.Add(this.PurchaseHistoryLabel);
            this.Name = "PurchaseHistoryStart";
            this.Text = "PurchaseHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseHistoryDataGridDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRangeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchaseHistoryLabel;
        private System.Windows.Forms.DataGridView PurchaseHistoryDataGridDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button FilterDateButton;
        private System.Windows.Forms.Button ClearFiltersButtons;
        private System.Windows.Forms.NumericUpDown PriceRangeStart;
        private System.Windows.Forms.NumericUpDown PriceRangeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FilterByPrice;
        private System.Windows.Forms.Button FilterByPriceAndDate;
    }
}