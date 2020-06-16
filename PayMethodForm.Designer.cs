namespace TheMerchShopGui {
    partial class PayMethodForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.PayWithCreditCardButton = new System.Windows.Forms.Button();
            this.PayWithCashOnHandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your method of payment";
            // 
            // PayWithCreditCardButton
            // 
            this.PayWithCreditCardButton.Location = new System.Drawing.Point(77, 165);
            this.PayWithCreditCardButton.Name = "PayWithCreditCardButton";
            this.PayWithCreditCardButton.Size = new System.Drawing.Size(210, 89);
            this.PayWithCreditCardButton.TabIndex = 1;
            this.PayWithCreditCardButton.Text = "Credit Card";
            this.PayWithCreditCardButton.UseVisualStyleBackColor = true;
            this.PayWithCreditCardButton.Click += new System.EventHandler(this.PayWithCreditCard);
            // 
            // PayWithCashOnHandButton
            // 
            this.PayWithCashOnHandButton.Location = new System.Drawing.Point(470, 165);
            this.PayWithCashOnHandButton.Name = "PayWithCashOnHandButton";
            this.PayWithCashOnHandButton.Size = new System.Drawing.Size(210, 89);
            this.PayWithCashOnHandButton.TabIndex = 2;
            this.PayWithCashOnHandButton.Text = "My Cash-on-hand";
            this.PayWithCashOnHandButton.UseVisualStyleBackColor = true;
            this.PayWithCashOnHandButton.Click += new System.EventHandler(this.PayWithCashOnHand);
            // 
            // PayMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayWithCashOnHandButton);
            this.Controls.Add(this.PayWithCreditCardButton);
            this.Controls.Add(this.label1);
            this.Name = "PayMethodForm";
            this.Text = "PayMethodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayWithCreditCardButton;
        private System.Windows.Forms.Button PayWithCashOnHandButton;
    }
}