namespace HotelManagement
{
    partial class frm_Customer
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
            dgv_listCustomer = new DataGridView();
            txt_email = new TextBox();
            label4 = new Label();
            btn_edit = new Button();
            btn_add = new Button();
            btn_search = new Button();
            btn_Referesh = new Button();
            txt_phone = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            txt_address = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgv_listCustomer
            // 
            dgv_listCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listCustomer.Location = new Point(213, 35);
            dgv_listCustomer.Name = "dgv_listCustomer";
            dgv_listCustomer.RowTemplate.Height = 25;
            dgv_listCustomer.Size = new Size(575, 403);
            dgv_listCustomer.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(12, 141);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(195, 23);
            txt_email.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 123);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(151, 250);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(55, 23);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(151, 221);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(55, 23);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(90, 250);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(55, 23);
            btn_search.TabIndex = 13;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Referesh
            // 
            btn_Referesh.Location = new Point(90, 221);
            btn_Referesh.Name = "btn_Referesh";
            btn_Referesh.Size = new Size(55, 23);
            btn_Referesh.TabIndex = 14;
            btn_Referesh.Text = "Refresh";
            btn_Referesh.UseVisualStyleBackColor = true;
            btn_Referesh.Click += btn_Referesh_Click;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(12, 97);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(195, 23);
            txt_phone.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 15;
            label1.Text = "Phone";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(12, 53);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(195, 23);
            txt_name.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(12, 192);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(195, 23);
            txt_address.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 19;
            label3.Text = "Address";
            // 
            // frm_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_address);
            Controls.Add(label3);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(txt_phone);
            Controls.Add(label1);
            Controls.Add(btn_Referesh);
            Controls.Add(btn_search);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(txt_email);
            Controls.Add(label4);
            Controls.Add(dgv_listCustomer);
            Name = "frm_Customer";
            Text = "Customer Management";
            Load += frm_listCustomer_Load;
            Controls.SetChildIndex(dgv_listCustomer, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txt_email, 0);
            Controls.SetChildIndex(btn_edit, 0);
            Controls.SetChildIndex(btn_add, 0);
            Controls.SetChildIndex(btn_search, 0);
            Controls.SetChildIndex(btn_Referesh, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txt_phone, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txt_name, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txt_address, 0);
            ((System.ComponentModel.ISupportInitialize)dgv_listCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listCustomer;
        private TextBox txt_email;
        private Label label4;
        private ComboBox cbx_status;
        private ComboBox cbx_roomType;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_search;
        private Button btn_Referesh;
        private TextBox txt_phone;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private TextBox txt_address;
        private Label label3;
    }
}