namespace TheMerchShopGui {
    partial class Form1 {
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.button1);
            this.loginGroupBox.Controls.Add(this.loginPassword);
            this.loginGroupBox.Controls.Add(this.label2);
            this.loginGroupBox.Controls.Add(this.loginUsername);
            this.loginGroupBox.Controls.Add(this.label1);
            this.loginGroupBox.Location = new System.Drawing.Point(135, 78);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(447, 352);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(128, 66);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(228, 26);
            this.loginUsername.TabIndex = 1;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(128, 172);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(228, 26);
            this.loginPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.signupPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.signupUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(721, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signup";
            // 
            // signupPassword
            // 
            this.signupPassword.Location = new System.Drawing.Point(128, 172);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.PasswordChar = '*';
            this.signupPassword.Size = new System.Drawing.Size(228, 26);
            this.signupPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // signupUsername
            // 
            this.signupUsername.Location = new System.Drawing.Point(128, 66);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(228, 26);
            this.signupUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loginButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 71);
            this.button2.TabIndex = 5;
            this.button2.Text = "Signup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.signupButton);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(146, 458);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 30);
            this.errorMessage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 559);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorMessage;
    }
}

