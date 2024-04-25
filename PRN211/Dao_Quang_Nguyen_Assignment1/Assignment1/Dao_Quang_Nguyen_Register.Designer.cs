namespace Assignment1
{
    partial class Register
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            gbGender = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lbGender = new Label();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            btnBack = new Button();
            btnRegister = new Button();
            lbDOB = new Label();
            dtDOB = new DateTimePicker();
            lbFullname = new Label();
            txtFullname = new TextBox();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(311, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(312, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 27);
            txtUsername.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(172, 68);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(125, 35);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(165, 22);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(132, 35);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Username:";
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rbFemale);
            gbGender.Controls.Add(rbMale);
            gbGender.Location = new Point(309, 211);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(281, 63);
            gbGender.TabIndex = 12;
            gbGender.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(158, 26);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(6, 26);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbGender.Location = new Point(196, 221);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(101, 35);
            lbGender.TabIndex = 13;
            lbGender.Text = "Gender:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(210, 171);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(80, 35);
            lbEmail.TabIndex = 14;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 27);
            txtEmail.TabIndex = 15;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbCity.Location = new Point(229, 272);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(61, 35);
            lbCity.TabIndex = 16;
            lbCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(311, 280);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(247, 27);
            txtCity.TabIndex = 17;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(181, 373);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 50);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonShadow;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.HighlightText;
            btnRegister.Location = new Point(419, 373);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 50);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbDOB
            // 
            lbDOB.AutoSize = true;
            lbDOB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbDOB.Location = new Point(136, 320);
            lbDOB.Name = "lbDOB";
            lbDOB.Size = new Size(161, 35);
            lbDOB.TabIndex = 20;
            lbDOB.Text = "Date of birth:";
            // 
            // dtDOB
            // 
            dtDOB.Location = new Point(312, 320);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(278, 27);
            dtDOB.TabIndex = 21;
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbFullname.Location = new Point(165, 120);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(120, 35);
            lbFullname.TabIndex = 22;
            lbFullname.Text = "Fullname:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(309, 128);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(247, 27);
            txtFullname.TabIndex = 23;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFullname);
            Controls.Add(lbFullname);
            Controls.Add(dtDOB);
            Controls.Add(lbDOB);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbGender);
            Controls.Add(gbGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private GroupBox gbGender;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lbGender;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbCity;
        private TextBox txtCity;
        private Button btnBack;
        private Button btnRegister;
        private Label lbDOB;
        private DateTimePicker dtDOB;
        private Label lbFullname;
        private TextBox txtFullname;
    }
}