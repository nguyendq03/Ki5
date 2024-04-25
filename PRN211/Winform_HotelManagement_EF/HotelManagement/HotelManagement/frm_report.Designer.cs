namespace HotelManagement
{
    partial class frm_Report
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
            dgv_listReport = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cbx_reportType = new ComboBox();
            btn_search = new Button();
            btn_Referesh = new Button();
            label1 = new Label();
            dp_startDate = new DateTimePicker();
            dp_endDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_listReport).BeginInit();
            SuspendLayout();
            // 
            // dgv_listReport
            // 
            dgv_listReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listReport.Location = new Point(213, 35);
            dgv_listReport.Name = "dgv_listReport";
            dgv_listReport.RowTemplate.Height = 25;
            dgv_listReport.Size = new Size(575, 403);
            dgv_listReport.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Report Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Start Date";
            // 
            // cbx_reportType
            // 
            cbx_reportType.FormattingEnabled = true;
            cbx_reportType.Location = new Point(12, 53);
            cbx_reportType.Name = "cbx_reportType";
            cbx_reportType.Size = new Size(195, 23);
            cbx_reportType.TabIndex = 10;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(152, 126);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(55, 23);
            btn_search.TabIndex = 13;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_Referesh
            // 
            btn_Referesh.Location = new Point(91, 126);
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
            label1.Location = new Point(113, 79);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 15;
            label1.Text = "End Date";
            // 
            // dp_startDate
            // 
            dp_startDate.CustomFormat = "dd/MM/yyyy";
            dp_startDate.Format = DateTimePickerFormat.Custom;
            dp_startDate.Location = new Point(12, 97);
            dp_startDate.Name = "dp_startDate";
            dp_startDate.Size = new Size(95, 23);
            dp_startDate.TabIndex = 16;
            // 
            // dp_endDate
            // 
            dp_endDate.CustomFormat = "dd/MM/yyyy";
            dp_endDate.Format = DateTimePickerFormat.Custom;
            dp_endDate.Location = new Point(113, 97);
            dp_endDate.Name = "dp_endDate";
            dp_endDate.Size = new Size(95, 23);
            dp_endDate.TabIndex = 17;
            // 
            // frm_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dp_endDate);
            Controls.Add(dp_startDate);
            Controls.Add(label1);
            Controls.Add(btn_Referesh);
            Controls.Add(btn_search);
            Controls.Add(cbx_reportType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_listReport);
            Name = "frm_Report";
            Text = "Report";
            Load += frm_report_Load;
            Controls.SetChildIndex(dgv_listReport, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(cbx_reportType, 0);
            Controls.SetChildIndex(btn_search, 0);
            Controls.SetChildIndex(btn_Referesh, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(dp_startDate, 0);
            Controls.SetChildIndex(dp_endDate, 0);
            ((System.ComponentModel.ISupportInitialize)dgv_listReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_listReport;
        private Label label2;
        private Label label3;
        private ComboBox cbx_reportType;
        private Button btn_search;
        private Button btn_Referesh;
        private Label label1;
        private DateTimePicker dp_startDate;
        private DateTimePicker dp_endDate;
    }
}