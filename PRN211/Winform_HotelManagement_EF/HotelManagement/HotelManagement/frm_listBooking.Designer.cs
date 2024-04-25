namespace HotelManagement
{
    partial class frm_Booking
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
            dgv_listBooking = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txt_Price = new TextBox();
            label4 = new Label();
            cbx_room = new ComboBox();
            cbx_customer = new ComboBox();
            btn_edit = new Button();
            btn_add = new Button();
            btn_search = new Button();
            btn_Referesh = new Button();
            label1 = new Label();
            dp_checkin = new DateTimePicker();
            dp_checkout = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listBooking).BeginInit();
            SuspendLayout();
            // 
            // dgv_listBooking
            // 
            dgv_listBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listBooking.Location = new Point(213, 35);
            dgv_listBooking.Name = "dgv_listBooking";
            dgv_listBooking.RowTemplate.Height = 25;
            dgv_listBooking.Size = new Size(575, 403);
            dgv_listBooking.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Room";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(12, 252);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(195, 23);
            txt_Price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // cbx_room
            // 
            cbx_room.FormattingEnabled = true;
            cbx_room.Location = new Point(12, 96);
            cbx_room.Name = "cbx_room";
            cbx_room.Size = new Size(195, 23);
            cbx_room.TabIndex = 9;
            // 
            // cbx_customer
            // 
            cbx_customer.FormattingEnabled = true;
            cbx_customer.Location = new Point(12, 52);
            cbx_customer.Name = "cbx_customer";
            cbx_customer.Size = new Size(195, 23);
            cbx_customer.TabIndex = 10;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(152, 317);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(55, 23);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(152, 288);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(55, 23);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(91, 317);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(55, 23);
            btn_search.TabIndex = 13;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Referesh
            // 
            btn_Referesh.Location = new Point(91, 288);
            btn_Referesh.Name = "btn_Referesh";
            btn_Referesh.Size = new Size(55, 23);
            btn_Referesh.TabIndex = 14;
            btn_Referesh.Text = "Refresh";
            btn_Referesh.UseVisualStyleBackColor = true;
            btn_Referesh.Click += btn_Referesh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 15;
            label1.Text = "Check In";
            // 
            // dp_checkin
            // 
            dp_checkin.CustomFormat = "dd/MM/yyyy hh:mm";
            dp_checkin.Format = DateTimePickerFormat.Custom;
            dp_checkin.Location = new Point(12, 145);
            dp_checkin.Name = "dp_checkin";
            dp_checkin.Size = new Size(195, 23);
            dp_checkin.TabIndex = 16;
            // 
            // dp_checkout
            // 
            dp_checkout.CustomFormat = "dd/MM/yyyy hh:mm";
            dp_checkout.Format = DateTimePickerFormat.Custom;
            dp_checkout.Location = new Point(12, 197);
            dp_checkout.Name = "dp_checkout";
            dp_checkout.Size = new Size(195, 23);
            dp_checkout.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 17;
            label5.Text = "Check Out";
            // 
            // frm_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dp_checkout);
            Controls.Add(label5);
            Controls.Add(dp_checkin);
            Controls.Add(label1);
            Controls.Add(btn_Referesh);
            Controls.Add(btn_search);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(cbx_customer);
            Controls.Add(cbx_room);
            Controls.Add(txt_Price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_listBooking);
            Name = "frm_Booking";
            Text = "Booking Management";
            Load += frm_listBooking_Load;
            Controls.SetChildIndex(dgv_listBooking, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txt_Price, 0);
            Controls.SetChildIndex(cbx_room, 0);
            Controls.SetChildIndex(cbx_customer, 0);
            Controls.SetChildIndex(btn_edit, 0);
            Controls.SetChildIndex(btn_add, 0);
            Controls.SetChildIndex(btn_search, 0);
            Controls.SetChildIndex(btn_Referesh, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dp_checkin, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(dp_checkout, 0);
            ((System.ComponentModel.ISupportInitialize)dgv_listBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listBooking;
        private Label label2;
        private Label label3;
        private TextBox txt_Price;
        private Label label4;
        private ComboBox cbx_room;
        private ComboBox cbx_customer;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_search;
        private Button btn_Referesh;
        private Label label1;
        private DateTimePicker dp_checkin;
        private DateTimePicker dp_checkout;
        private Label label5;
    }
}