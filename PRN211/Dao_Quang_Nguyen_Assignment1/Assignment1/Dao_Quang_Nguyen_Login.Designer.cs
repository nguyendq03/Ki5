namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignin = new Button();
            lbSignup = new Label();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(93, 85);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(132, 35);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(93, 149);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(125, 35);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(231, 94);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.MenuHighlight;
            btnSignin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.ForeColor = SystemColors.ButtonHighlight;
            btnSignin.Location = new Point(349, 244);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(128, 48);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbSignup.Location = new Point(400, 204);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(64, 23);
            lbSignup.TabIndex = 5;
            lbSignup.Text = "Singup";
            lbSignup.Click += lbSignup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbSignup);
            Controls.Add(btnSignin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "13_NguyenQuangSu_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignin;
        private Label lbSignup;
    }
}
