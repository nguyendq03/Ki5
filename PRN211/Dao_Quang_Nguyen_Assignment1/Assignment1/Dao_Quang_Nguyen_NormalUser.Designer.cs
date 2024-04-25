namespace Assignment1
{
    partial class _Dao_Quang_Nguyen_NormalUser
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
            btnView = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Location = new Point(256, 113);
            btnView.Name = "btnView";
            btnView.Size = new Size(287, 95);
            btnView.TabIndex = 0;
            btnView.Text = "View Profile";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(256, 252);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(287, 90);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // _Dao_Quang_Nguyen_NormalUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnView);
            Name = "_Dao_Quang_Nguyen_NormalUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen_NormalUser";
            Load += NormalUser_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnView;
        private Button btnUpdate;
    }
}