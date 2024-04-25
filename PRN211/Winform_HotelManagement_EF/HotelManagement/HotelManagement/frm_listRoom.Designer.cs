namespace HotelManagement
{
    partial class frm_Room
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
            dgv_listRoom = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txt_Price = new TextBox();
            label4 = new Label();
            cbx_status = new ComboBox();
            cbx_roomType = new ComboBox();
            btn_edit = new Button();
            btn_add = new Button();
            btn_search = new Button();
            btn_Referesh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listRoom).BeginInit();
            SuspendLayout();
            // 
            // dgv_listRoom
            // 
            dgv_listRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listRoom.Location = new Point(213, 35);
            dgv_listRoom.Name = "dgv_listRoom";
            dgv_listRoom.RowTemplate.Height = 25;
            dgv_listRoom.Size = new Size(575, 403);
            dgv_listRoom.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Room type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(12, 139);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(195, 23);
            txt_Price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // cbx_status
            // 
            cbx_status.FormattingEnabled = true;
            cbx_status.Location = new Point(12, 95);
            cbx_status.Name = "cbx_status";
            cbx_status.Size = new Size(195, 23);
            cbx_status.TabIndex = 9;
            // 
            // cbx_roomType
            // 
            cbx_roomType.FormattingEnabled = true;
            cbx_roomType.Location = new Point(12, 51);
            cbx_roomType.Name = "cbx_roomType";
            cbx_roomType.Size = new Size(195, 23);
            cbx_roomType.TabIndex = 10;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(152, 199);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(55, 23);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(152, 170);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(55, 23);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(91, 199);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(55, 23);
            btn_search.TabIndex = 13;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Referesh
            // 
            btn_Referesh.Location = new Point(91, 170);
            btn_Referesh.Name = "btn_Referesh";
            btn_Referesh.Size = new Size(55, 23);
            btn_Referesh.TabIndex = 14;
            btn_Referesh.Text = "Refresh";
            btn_Referesh.UseVisualStyleBackColor = true;
            btn_Referesh.Click += btn_Referesh_Click;
            // 
            // frm_Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Referesh);
            Controls.Add(btn_search);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(cbx_roomType);
            Controls.Add(cbx_status);
            Controls.Add(txt_Price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_listRoom);
            Name = "frm_Room";
            Text = "Room Management";
            Load += frm_listRoom_Load;
            Controls.SetChildIndex(dgv_listRoom, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txt_Price, 0);
            Controls.SetChildIndex(cbx_status, 0);
            Controls.SetChildIndex(cbx_roomType, 0);
            Controls.SetChildIndex(btn_edit, 0);
            Controls.SetChildIndex(btn_add, 0);
            Controls.SetChildIndex(btn_search, 0);
            Controls.SetChildIndex(btn_Referesh, 0);
            ((System.ComponentModel.ISupportInitialize)dgv_listRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listRoom;
        private Label label2;
        private Label label3;
        private TextBox txt_Price;
        private Label label4;
        private ComboBox cbx_status;
        private ComboBox cbx_roomType;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_search;
        private Button btn_Referesh;
    }
}