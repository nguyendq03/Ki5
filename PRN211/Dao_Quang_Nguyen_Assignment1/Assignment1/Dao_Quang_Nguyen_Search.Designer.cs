namespace Assignment1
{
    partial class _Dao_Quang_Nguyen_Search
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
            txtSearch = new TextBox();
            lbSearchItem = new Label();
            btnSearch = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(292, 162);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(246, 27);
            txtSearch.TabIndex = 4;
            // 
            // lbSearchItem
            // 
            lbSearchItem.AutoSize = true;
            lbSearchItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbSearchItem.Location = new Point(154, 153);
            lbSearchItem.Name = "lbSearchItem";
            lbSearchItem.Size = new Size(132, 35);
            lbSearchItem.TabIndex = 3;
            lbSearchItem.Text = "Username:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.MenuHighlight;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(378, 247);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 48);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuHighlight;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(194, 247);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 48);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // _Dao_Quang_Nguyen_Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearchItem);
            Name = "_Dao_Quang_Nguyen_Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen_Search";
            Load += Search_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lbSearchItem;
        private Button btnSearch;
        private Button btnBack;
    }
}