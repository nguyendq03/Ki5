using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HotelManagement
{
    public partial class frm_Report : frm_base
    {
        HotelManagementSystemContext _context;

        public frm_Report(HotelManagementSystemContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {


            LoadData();
            CustomGrid();
        }

        private void LoadData()
        {
            cbx_reportType.DataSource = new List<ReportType>
            {
                new ReportType { Name = "Customer", Value = 1 },
                new ReportType { Name = "Room", Value = 2 },
            };
            cbx_reportType.DisplayMember = "Name";
            cbx_reportType.ValueMember = "Value";
            cbx_reportType.SelectedIndex = -1;

            dgv_listReport.DataSource = null;
            dgv_listReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CustomGrid()
        {
            this.AutoSize = true;
            dgv_listReport.Width = this.Width - 50;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbx_reportType.SelectedIndex == 1)
            {
                MessageBox.Show("Please select report type");
                return;
            }

            dgv_listReport.DataSource = null;

            if (cbx_reportType.SelectedValue.ToString() == "1")
            {
                var customerReport = _context.Bookings
                    .Include(x => x.Customer)
                    .Where(x => x.CheckInDate >= dp_startDate.Value && x.CheckInDate <= dp_endDate.Value)
                    .GroupBy(x => x.Customer)
                    .Select(x => new
                    {
                        CustomerName = x.Key.Name,
                        TotalBooking = x.Count(),
                        TotalAmount = x.Sum(x => x.TotalPrice)
                    }).ToList();
                dgv_listReport.DataSource = customerReport;
            }

            if (cbx_reportType.SelectedValue.ToString() == "2")
            {
                var roomReport = _context.Bookings
                    .Include(x => x.Room)
                    .Where(x => x.CheckInDate >= dp_startDate.Value && x.CheckInDate <= dp_endDate.Value)
                    .GroupBy(x => x.Room)
                    .Select(x => new
                    {
                        RoomName = x.Key.RoomType,
                        TotalBooking = x.Count(),
                        TotalAmount = x.Sum(x => x.TotalPrice)
                    }).ToList();
                dgv_listReport.DataSource = roomReport;
            }

        }

        private void btn_Referesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
