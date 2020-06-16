namespace TheMerchShopGui {
    partial class CreditCardPaymentForm {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AmountOwedLabel = new System.Windows.Forms.Label();
            this.AmountBeingPayedLabel = new System.Windows.Forms.Label();
            this.AmountBeingPayedUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreditCardInfoBox = new System.Windows.Forms.GroupBox();
            this.CVCUpDownField = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CCNumberTextBox = new System.Windows.Forms.TextBox();
            this.CCExpDateLabel = new System.Windows.Forms.Label();
            this.CreditCardCVCLabel = new System.Windows.Forms.Label();
            this.CCNumberLabel = new System.Windows.Forms.Label();
            this.PayWithCCButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBeingPayedUpDown)).BeginInit();
            this.CreditCardInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVCUpDownField)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(188, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(155, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Pay With Credit Card";
            // 
            // AmountOwedLabel
            // 
            this.AmountOwedLabel.AutoSize = true;
            this.AmountOwedLabel.Location = new System.Drawing.Point(54, 95);
            this.AmountOwedLabel.Name = "AmountOwedLabel";
            this.AmountOwedLabel.Size = new System.Drawing.Size(158, 20);
            this.AmountOwedLabel.TabIndex = 1;
            this.AmountOwedLabel.Text = "Amount Owed: $0.00";
            // 
            // AmountBeingPayedLabel
            // 
            this.AmountBeingPayedLabel.AutoSize = true;
            this.AmountBeingPayedLabel.Location = new System.Drawing.Point(56, 145);
            this.AmountBeingPayedLabel.Name = "AmountBeingPayedLabel";
            this.AmountBeingPayedLabel.Size = new System.Drawing.Size(153, 20);
            this.AmountBeingPayedLabel.TabIndex = 2;
            this.AmountBeingPayedLabel.Text = "Amount your paying:";
            // 
            // AmountBeingPayedUpDown
            // 
            this.AmountBeingPayedUpDown.DecimalPlaces = 2;
            this.AmountBeingPayedUpDown.Location = new System.Drawing.Point(232, 143);
            this.AmountBeingPayedUpDown.Name = "AmountBeingPayedUpDown";
            this.AmountBeingPayedUpDown.Size = new System.Drawing.Size(75, 26);
            this.AmountBeingPayedUpDown.TabIndex = 3;
            // 
            // CreditCardInfoBox
            // 
            this.CreditCardInfoBox.Controls.Add(this.CVCUpDownField);
            this.CreditCardInfoBox.Controls.Add(this.dateTimePicker1);
            this.CreditCardInfoBox.Controls.Add(this.CCNumberTextBox);
            this.CreditCardInfoBox.Controls.Add(this.CCExpDateLabel);
            this.CreditCardInfoBox.Controls.Add(this.CreditCardCVCLabel);
            this.CreditCardInfoBox.Controls.Add(this.CCNumberLabel);
            this.CreditCardInfoBox.Location = new System.Drawing.Point(58, 208);
            this.CreditCardInfoBox.Name = "CreditCardInfoBox";
            this.CreditCardInfoBox.Size = new System.Drawing.Size(500, 220);
            this.CreditCardInfoBox.TabIndex = 4;
            this.CreditCardInfoBox.TabStop = false;
            this.CreditCardInfoBox.Text = "Credit Card Info";
            // 
            // CVCUpDownField
            // 
            this.CVCUpDownField.Location = new System.Drawing.Point(101, 160);
            this.CVCUpDownField.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CVCUpDownField.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CVCUpDownField.Name = "CVCUpDownField";
            this.CVCUpDownField.Size = new System.Drawing.Size(91, 26);
            this.CVCUpDownField.TabIndex = 6;
            this.CVCUpDownField.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // CCNumberTextBox
            // 
            this.CCNumberTextBox.Location = new System.Drawing.Point(101, 38);
            this.CCNumberTextBox.Name = "CCNumberTextBox";
            this.CCNumberTextBox.Size = new System.Drawing.Size(277, 26);
            this.CCNumberTextBox.TabIndex = 3;
            // 
            // CCExpDateLabel
            // 
            this.CCExpDateLabel.AutoSize = true;
            this.CCExpDateLabel.Location = new System.Drawing.Point(18, 107);
            this.CCExpDateLabel.Name = "CCExpDateLabel";
            this.CCExpDateLabel.Size = new System.Drawing.Size(75, 20);
            this.CCExpDateLabel.TabIndex = 2;
            this.CCExpDateLabel.Text = "Exp Date";
            // 
            // CreditCardCVCLabel
            // 
            this.CreditCardCVCLabel.AutoSize = true;
            this.CreditCardCVCLabel.Location = new System.Drawing.Point(18, 162);
            this.CreditCardCVCLabel.Name = "CreditCardCVCLabel";
            this.CreditCardCVCLabel.Size = new System.Drawing.Size(42, 20);
            this.CreditCardCVCLabel.TabIndex = 1;
            this.CreditCardCVCLabel.Text = "CVC";
            // 
            // CCNumberLabel
            // 
            this.CCNumberLabel.AutoSize = true;
            this.CCNumberLabel.Location = new System.Drawing.Point(18, 41);
            this.CCNumberLabel.Name = "CCNumberLabel";
            this.CCNumberLabel.Size = new System.Drawing.Size(44, 20);
            this.CCNumberLabel.TabIndex = 0;
            this.CCNumberLabel.Text = "CC #";
            // 
            // PayWithCCButton
            // 
            this.PayWithCCButton.Location = new System.Drawing.Point(586, 344);
            this.PayWithCCButton.Name = "PayWithCCButton";
            this.PayWithCCButton.Size = new System.Drawing.Size(202, 84);
            this.PayWithCCButton.TabIndex = 5;
            this.PayWithCCButton.Text = "Pay now";
            this.PayWithCCButton.UseVisualStyleBackColor = true;
            this.PayWithCCButton.Click += new System.EventHandler(this.CompletePaymentWithCC);
            // 
            // CreditCardPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayWithCCButton);
            this.Controls.Add(this.CreditCardInfoBox);
            this.Controls.Add(this.AmountBeingPayedUpDown);
            this.Controls.Add(this.AmountBeingPayedLabel);
            this.Controls.Add(this.AmountOwedLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CreditCardPaymentForm";
            this.Text = "CreditCardPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountBeingPayedUpDown)).EndInit();
            this.CreditCardInfoBox.ResumeLayout(false);
            this.CreditCardInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVCUpDownField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AmountOwedLabel;
        private System.Windows.Forms.Label AmountBeingPayedLabel;
        private System.Windows.Forms.NumericUpDown AmountBeingPayedUpDown;
        private System.Windows.Forms.GroupBox CreditCardInfoBox;
        private System.Windows.Forms.NumericUpDown CVCUpDownField;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CCNumberTextBox;
        private System.Windows.Forms.Label CCExpDateLabel;
        private System.Windows.Forms.Label CreditCardCVCLabel;
        private System.Windows.Forms.Label CCNumberLabel;
        private System.Windows.Forms.Button PayWithCCButton;
    }
}