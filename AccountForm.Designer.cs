namespace TheMerchShopGui {
    partial class AccountForm {
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
            this.AccountTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.cohLabel = new System.Windows.Forms.Label();
            this.PayBalanceButton = new System.Windows.Forms.Button();
            this.AddcohButton = new System.Windows.Forms.Button();
            this.PurchaseHistoryButton = new System.Windows.Forms.Button();
            this.PurchaseHistoryTotalLabel = new System.Windows.Forms.Label();
            this.PurchaseHistoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountTitle
            // 
            this.AccountTitle.AutoSize = true;
            this.AccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTitle.Location = new System.Drawing.Point(206, 25);
            this.AccountTitle.Name = "AccountTitle";
            this.AccountTitle.Size = new System.Drawing.Size(366, 40);
            this.AccountTitle.TabIndex = 1;
            this.AccountTitle.Text = "Username\'s Account";
            this.AccountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance (owed)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cash on hand (credit)";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(63, 186);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(49, 20);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "$0.00";
            // 
            // cohLabel
            // 
            this.cohLabel.AutoSize = true;
            this.cohLabel.Location = new System.Drawing.Point(329, 186);
            this.cohLabel.Name = "cohLabel";
            this.cohLabel.Size = new System.Drawing.Size(49, 20);
            this.cohLabel.TabIndex = 5;
            this.cohLabel.Text = "$0.00";
            // 
            // PayBalanceButton
            // 
            this.PayBalanceButton.Location = new System.Drawing.Point(60, 266);
            this.PayBalanceButton.Name = "PayBalanceButton";
            this.PayBalanceButton.Size = new System.Drawing.Size(181, 83);
            this.PayBalanceButton.TabIndex = 6;
            this.PayBalanceButton.Text = "Pay Balance";
            this.PayBalanceButton.UseVisualStyleBackColor = true;
            this.PayBalanceButton.Click += new System.EventHandler(this.PayBalance);
            // 
            // AddcohButton
            // 
            this.AddcohButton.Location = new System.Drawing.Point(300, 266);
            this.AddcohButton.Name = "AddcohButton";
            this.AddcohButton.Size = new System.Drawing.Size(181, 83);
            this.AddcohButton.TabIndex = 7;
            this.AddcohButton.Text = "Add Cash";
            this.AddcohButton.UseVisualStyleBackColor = true;
            this.AddcohButton.Click += new System.EventHandler(this.Addcoh_click);
            // 
            // PurchaseHistoryButton
            // 
            this.PurchaseHistoryButton.Location = new System.Drawing.Point(552, 266);
            this.PurchaseHistoryButton.Name = "PurchaseHistoryButton";
            this.PurchaseHistoryButton.Size = new System.Drawing.Size(181, 83);
            this.PurchaseHistoryButton.TabIndex = 10;
            this.PurchaseHistoryButton.Text = "Purchase History";
            this.PurchaseHistoryButton.UseVisualStyleBackColor = true;
            this.PurchaseHistoryButton.Click += new System.EventHandler(this.PurchaseHistory_click);
            // 
            // PurchaseHistoryTotalLabel
            // 
            this.PurchaseHistoryTotalLabel.AutoSize = true;
            this.PurchaseHistoryTotalLabel.Location = new System.Drawing.Point(581, 186);
            this.PurchaseHistoryTotalLabel.Name = "PurchaseHistoryTotalLabel";
            this.PurchaseHistoryTotalLabel.Size = new System.Drawing.Size(27, 30);
            this.PurchaseHistoryTotalLabel.TabIndex = 9;
            this.PurchaseHistoryTotalLabel.Text = "0";
            // 
            // PurchaseHistoryLabel
            // 
            this.PurchaseHistoryLabel.AutoSize = true;
            this.PurchaseHistoryLabel.Location = new System.Drawing.Point(581, 133);
            this.PurchaseHistoryLabel.Name = "PurchaseHistoryLabel";
            this.PurchaseHistoryLabel.Size = new System.Drawing.Size(185, 30);
            this.PurchaseHistoryLabel.TabIndex = 8;
            this.PurchaseHistoryLabel.Text = "Total Purchases";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PurchaseHistoryButton);
            this.Controls.Add(this.PurchaseHistoryTotalLabel);
            this.Controls.Add(this.PurchaseHistoryLabel);
            this.Controls.Add(this.AddcohButton);
            this.Controls.Add(this.PayBalanceButton);
            this.Controls.Add(this.cohLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountTitle);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label cohLabel;
        private System.Windows.Forms.Button PayBalanceButton;
        private System.Windows.Forms.Button AddcohButton;
        private System.Windows.Forms.Button PurchaseHistoryButton;
        private System.Windows.Forms.Label PurchaseHistoryTotalLabel;
        private System.Windows.Forms.Label PurchaseHistoryLabel;
    }
}