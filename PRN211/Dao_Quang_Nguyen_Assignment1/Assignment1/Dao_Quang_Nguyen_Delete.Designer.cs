namespace Assignment1
{
    partial class _Dao_Quang_Nguyen
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
            label1 = new Label();
            txtUserID = new TextBox();
            btnBack = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 120);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter UserID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(298, 117);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(206, 27);
            txtUserID.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(178, 239);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 62);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(370, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // _Dao_Quang_Nguyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Name = "_Dao_Quang_Nguyen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserID;
        private Button btnBack;
        private Button btnDelete;
    }
}