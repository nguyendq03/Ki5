namespace Assignment1
{
    partial class _Dao_Quang_Nguyen_ViewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Dao_Quang_Nguyen_ViewProfile));
            pbAvatar = new PictureBox();
            lbName = new Label();
            lbEmail = new Label();
            gbGender = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dtDOB = new DateTimePicker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            btnBack = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // pbAvatar
            // 
            pbAvatar.Image = (Image)resources.GetObject("pbAvatar.Image");
            pbAvatar.Location = new Point(12, 36);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(296, 366);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(354, 43);
            lbName.Name = "lbName";
            lbName.Size = new Size(72, 20);
            lbName.TabIndex = 1;
            lbName.Text = "FullName";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(354, 105);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rbFemale);
            gbGender.Controls.Add(rbMale);
            gbGender.Location = new Point(351, 183);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(281, 63);
            gbGender.TabIndex = 3;
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
            // dtDOB
            // 
            dtDOB.Location = new Point(354, 271);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(278, 27);
            dtDOB.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.HighlightText;
            btnBack.Location = new Point(413, 352);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 50);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(451, 42);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(453, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 7;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(357, 160);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(453, 157);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(179, 27);
            txtCity.TabIndex = 9;
            // 
            // _Dao_Quang_Nguyen_ViewProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnBack);
            Controls.Add(dtDOB);
            Controls.Add(gbGender);
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Controls.Add(pbAvatar);
            Name = "_Dao_Quang_Nguyen_ViewProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen_ViewProfile";
            Load += ViewProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAvatar;
        private Label lbName;
        private Label lbEmail;
        private GroupBox gbGender;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dtDOB;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btnBack;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label lbCity;
        private TextBox txtCity;
    }
}