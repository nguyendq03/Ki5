namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lbPreleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(134, 75);
            txtCarName.Margin = new Padding(2, 2, 2, 2);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(230, 27);
            txtCarName.TabIndex = 16;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(134, 37);
            txtCarID.Margin = new Padding(2, 2, 2, 2);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(230, 27);
            txtCarID.TabIndex = 15;
            // 
            // lbPreleaseYear
            // 
            lbPreleaseYear.AutoSize = true;
            lbPreleaseYear.Location = new Point(387, 78);
            lbPreleaseYear.Margin = new Padding(2, 0, 2, 0);
            lbPreleaseYear.Name = "lbPreleaseYear";
            lbPreleaseYear.Size = new Size(92, 20);
            lbPreleaseYear.TabIndex = 14;
            lbPreleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(387, 39);
            lbPrice.Margin = new Padding(2, 0, 2, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 13;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(33, 114);
            lbManufacturer.Margin = new Padding(2, 0, 2, 0);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 12;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(33, 78);
            lbCarName.Margin = new Padding(2, 0, 2, 0);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 11;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(33, 39);
            lbCarID.Margin = new Padding(2, 0, 2, 0);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 10;
            lbCarID.Text = "Car ID";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(134, 112);
            txtManufacturer.Margin = new Padding(2, 2, 2, 2);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(230, 27);
            txtManufacturer.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(475, 37);
            txtPrice.Margin = new Padding(2, 2, 2, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 27);
            txtPrice.TabIndex = 21;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(475, 75);
            txtReleaseYear.Margin = new Padding(2, 2, 2, 2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(230, 27);
            txtReleaseYear.TabIndex = 22;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(134, 152);
            btnLoad.Margin = new Padding(2, 2, 2, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 27);
            btnLoad.TabIndex = 23;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(337, 152);
            btnNew.Margin = new Padding(2, 2, 2, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(90, 27);
            btnNew.TabIndex = 24;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 152);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(33, 202);
            dgvCarList.Margin = new Padding(2, 2, 2, 2);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.RowTemplate.Height = 33;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(698, 180);
            dgvCarList.TabIndex = 26;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(337, 386);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 27);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 542);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbPreleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Activated += frmCarManagement_Activated;
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbPreleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}