
namespace TicketingSystem.ui
{
    partial class LoginForm
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
            this.usernameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Location = new System.Drawing.Point(156, 100);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(55, 13);
            this.usernameLb.TabIndex = 0;
            this.usernameLb.Text = "Username";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(156, 135);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(53, 13);
            this.passwordLb.TabIndex = 1;
            this.passwordLb.Text = "Password";
            // 
            // usernameTBox
            // 
            this.usernameTBox.Location = new System.Drawing.Point(229, 100);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(192, 20);
            this.usernameTBox.TabIndex = 2;
            // 
            // passwordTBox
            // 
            this.passwordTBox.Location = new System.Drawing.Point(229, 135);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(192, 20);
            this.passwordTBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(266, 184);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(97, 27);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 281);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Button loginBtn;
    }
}

