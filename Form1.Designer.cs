namespace prjStudentMarkbook
{
    partial class frmLoginCredentials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.mTBUsername = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.mTBPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(103, 92);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // mTBUsername
            // 
            this.mTBUsername.Location = new System.Drawing.Point(192, 94);
            this.mTBUsername.Mask = ">L|CCCCCCCCCCCCCCCCCCC";
            this.mTBUsername.Name = "mTBUsername";
            this.mTBUsername.PromptChar = ' ';
            this.mTBUsername.Size = new System.Drawing.Size(126, 20);
            this.mTBUsername.TabIndex = 1;
            this.mTBUsername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(103, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // mTBPassword
            // 
            this.mTBPassword.Location = new System.Drawing.Point(192, 120);
            this.mTBPassword.Mask = "CCCCCCCCCCCCCCCCCCCC";
            this.mTBPassword.Name = "mTBPassword";
            this.mTBPassword.PasswordChar = '*';
            this.mTBPassword.PromptChar = ' ';
            this.mTBPassword.Size = new System.Drawing.Size(126, 20);
            this.mTBPassword.TabIndex = 3;
            this.mTBPassword.ValidatingType = typeof(int);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Location = new System.Drawing.Point(263, 215);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLogin.TabIndex = 4;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(344, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLoginCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 249);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.mTBPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.mTBUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmLoginCredentials";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginCredentials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MaskedTextBox mTBUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.MaskedTextBox mTBPassword;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

