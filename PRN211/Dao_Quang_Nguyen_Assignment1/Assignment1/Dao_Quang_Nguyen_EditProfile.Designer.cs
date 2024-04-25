namespace Assignment1
{
    partial class _Dao_Quang_Nguyen_EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Dao_Quang_Nguyen_EditProfile));
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnBack = new Button();
            dtDOB = new DateTimePicker();
            gbGender = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lbEmail = new Label();
            lbName = new Label();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(488, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(486, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 14;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(379, 364);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 50);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dtDOB
            // 
            dtDOB.Location = new Point(395, 316);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(278, 27);
            dtDOB.TabIndex = 12;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rbFemale);
            gbGender.Controls.Add(rbMale);
            gbGender.Location = new Point(395, 233);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(281, 63);
            gbGender.TabIndex = 11;
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
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(389, 105);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(389, 43);
            lbName.Name = "lbName";
            lbName.Size = new Size(72, 20);
            lbName.TabIndex = 9;
            lbName.Text = "FullName";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonShadow;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.HighlightText;
            btnSave.Location = new Point(544, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 50);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(389, 162);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(486, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 27);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(389, 210);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 19;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(486, 207);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(179, 27);
            txtCity.TabIndex = 20;
            // 
            // _Dao_Quang_Nguyen_EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnBack);
            Controls.Add(dtDOB);
            Controls.Add(gbGender);
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Controls.Add(pictureBox1);
            Name = "_Dao_Quang_Nguyen_EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen_EditProfile";
            Load += EditProfile_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnBack;
        private DateTimePicker dtDOB;
        private GroupBox gbGender;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lbEmail;
        private Label lbName;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCity;
        private TextBox txtCity;
    }
}