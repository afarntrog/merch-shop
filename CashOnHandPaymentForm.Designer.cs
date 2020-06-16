namespace TheMerchShopGui {
    partial class CashOnHandPaymentForm {
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
            this.AmountOwedLabel = new System.Windows.Forms.Label();
            this.COHtitleLabel = new System.Windows.Forms.Label();
            this.CustomerCOHamountLabel = new System.Windows.Forms.Label();
            this.AmountBeingPayedUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountBeingPayedLabel = new System.Windows.Forms.Label();
            this.PayWithCOHbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBeingPayedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountOwedLabel
            // 
            this.AmountOwedLabel.AutoSize = true;
            this.AmountOwedLabel.Location = new System.Drawing.Point(138, 93);
            this.AmountOwedLabel.Name = "AmountOwedLabel";
            this.AmountOwedLabel.Size = new System.Drawing.Size(158, 20);
            this.AmountOwedLabel.TabIndex = 3;
            this.AmountOwedLabel.Text = "Amount Owed: $0.00";
            // 
            // COHtitleLabel
            // 
            this.COHtitleLabel.AutoSize = true;
            this.COHtitleLabel.Location = new System.Drawing.Point(272, 26);
            this.COHtitleLabel.Name = "COHtitleLabel";
            this.COHtitleLabel.Size = new System.Drawing.Size(270, 30);
            this.COHtitleLabel.TabIndex = 2;
            this.COHtitleLabel.Text = "Pay With Cash On Hand";
            // 
            // CustomerCOHamountLabel
            // 
            this.CustomerCOHamountLabel.AutoSize = true;
            this.CustomerCOHamountLabel.Location = new System.Drawing.Point(138, 153);
            this.CustomerCOHamountLabel.Name = "CustomerCOHamountLabel";
            this.CustomerCOHamountLabel.Size = new System.Drawing.Size(297, 30);
            this.CustomerCOHamountLabel.TabIndex = 4;
            this.CustomerCOHamountLabel.Text = "Your Cash-On-Hand $0.00";
            // 
            // AmountBeingPayedUpDown
            // 
            this.AmountBeingPayedUpDown.DecimalPlaces = 2;
            this.AmountBeingPayedUpDown.Location = new System.Drawing.Point(314, 220);
            this.AmountBeingPayedUpDown.Name = "AmountBeingPayedUpDown";
            this.AmountBeingPayedUpDown.Size = new System.Drawing.Size(75, 26);
            this.AmountBeingPayedUpDown.TabIndex = 6;
            // 
            // AmountBeingPayedLabel
            // 
            this.AmountBeingPayedLabel.AutoSize = true;
            this.AmountBeingPayedLabel.Location = new System.Drawing.Point(138, 222);
            this.AmountBeingPayedLabel.Name = "AmountBeingPayedLabel";
            this.AmountBeingPayedLabel.Size = new System.Drawing.Size(153, 20);
            this.AmountBeingPayedLabel.TabIndex = 5;
            this.AmountBeingPayedLabel.Text = "Amount your paying:";
            // 
            // PayWithCOHbutton
            // 
            this.PayWithCOHbutton.Location = new System.Drawing.Point(140, 291);
            this.PayWithCOHbutton.Name = "PayWithCOHbutton";
            this.PayWithCOHbutton.Size = new System.Drawing.Size(248, 98);
            this.PayWithCOHbutton.TabIndex = 7;
            this.PayWithCOHbutton.Text = "Pay Now";
            this.PayWithCOHbutton.UseVisualStyleBackColor = true;
            this.PayWithCOHbutton.Click += new System.EventHandler(this.PayWithCOH_click);
            // 
            // CashOnHandPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayWithCOHbutton);
            this.Controls.Add(this.AmountBeingPayedUpDown);
            this.Controls.Add(this.AmountBeingPayedLabel);
            this.Controls.Add(this.CustomerCOHamountLabel);
            this.Controls.Add(this.AmountOwedLabel);
            this.Controls.Add(this.COHtitleLabel);
            this.Name = "CashOnHandPaymentForm";
            this.Text = "CashOnHandPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountBeingPayedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountOwedLabel;
        private System.Windows.Forms.Label COHtitleLabel;
        private System.Windows.Forms.Label CustomerCOHamountLabel;
        private System.Windows.Forms.NumericUpDown AmountBeingPayedUpDown;
        private System.Windows.Forms.Label AmountBeingPayedLabel;
        private System.Windows.Forms.Button PayWithCOHbutton;
    }
}