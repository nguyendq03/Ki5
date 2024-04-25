namespace Assignment1
{
    partial class _Dao_Quang_Nguyen_MembersManagement
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
            dgvUser = new DataGridView();
            btnAdd = new Button();
            btnLoad = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearchBy = new Button();
            cbSearchBy = new ComboBox();
            btnFilter = new Button();
            cbFilterCity = new ComboBox();
            cbFilterGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(66, 27);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(655, 254);
            dgvUser.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 314);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(215, 314);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(382, 314);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(566, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchBy
            // 
            btnSearchBy.Location = new Point(67, 373);
            btnSearchBy.Name = "btnSearchBy";
            btnSearchBy.Size = new Size(94, 29);
            btnSearchBy.TabIndex = 5;
            btnSearchBy.Text = "Search By";
            btnSearchBy.UseVisualStyleBackColor = true;
            btnSearchBy.Click += btnSearchBy_Click;
            // 
            // cbSearchBy
            // 
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Items.AddRange(new object[] { "UserID", "Username", "FullName", "Email", "City" });
            cbSearchBy.Location = new Point(215, 373);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(151, 28);
            cbSearchBy.TabIndex = 6;
            cbSearchBy.Text = "-- Select options ---";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(430, 374);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter By";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cbFilterCity
            // 
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Items.AddRange(new object[] { "Hà Nội", "TPHCM" });
            cbFilterCity.Location = new Point(570, 376);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new Size(151, 28);
            cbFilterCity.TabIndex = 8;
            cbFilterCity.Text = "--Select a City ---";
            // 
            // cbFilterGender
            // 
            cbFilterGender.FormattingEnabled = true;
            cbFilterGender.Items.AddRange(new object[] { "Male", "Female" });
            cbFilterGender.Location = new Point(570, 410);
            cbFilterGender.Name = "cbFilterGender";
            cbFilterGender.Size = new Size(151, 28);
            cbFilterGender.TabIndex = 9;
            cbFilterGender.Text = "--Select a Gender---";
            // 
            // _Dao_Quang_Nguyen_MembersManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbFilterGender);
            Controls.Add(cbFilterCity);
            Controls.Add(btnFilter);
            Controls.Add(cbSearchBy);
            Controls.Add(btnSearchBy);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(dgvUser);
            Name = "_Dao_Quang_Nguyen_MembersManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_Dao_Quang_Nguyen_MembersManagement";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUser;
        private Button btnAdd;
        private Button btnLoad;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearchBy;
        private ComboBox cbSearchBy;
        private Button btnFilter;
        private ComboBox cbFilterCity;
        private ComboBox cbFilterGender;
    }
}