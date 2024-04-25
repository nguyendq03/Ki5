using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HotelManagement
{
    public partial class frm_Booking : frm_base
    {
        HotelManagementSystemContext _context;
        List<Booking> _bookings;
        Booking _selectedBooking;

        public frm_Booking(HotelManagementSystemContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void frm_listBooking_Load(object sender, EventArgs e)
        {



            LoadData();
            CustomGrid();
        }

        private void LoadData()
        {
            _bookings = _context.Bookings.Include(b => b.Customer).Include(b => b.Room).ToList();
            dgv_listBooking.DataSource = _bookings;
            dgv_listBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbx_customer.DataSource = _context.Customers.ToList();
            cbx_customer.DisplayMember = "Name";
            cbx_customer.ValueMember = "CustomerId";
            cbx_customer.SelectedIndex = -1;

            cbx_room.DataSource = _context.Rooms.ToList();
            cbx_room.DisplayMember = "RoomType";
            cbx_room.ValueMember = "RoomId";
            cbx_room.SelectedIndex = -1;
            cbx_room.SelectedIndexChanged += new EventHandler(cbx_room_SelectedIndexChanged);

            dp_checkin.Value = DateTime.Now;
            dp_checkout.Value = DateTime.Now;

            txt_Price.Text = "";
            txt_Price.ReadOnly = true;
        }

        private void cbx_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = cbx_room.SelectedItem as Room;
            if (room != null)
            {
                txt_Price.Text = room.Price.ToString();
            }
        }

        private void CustomGrid()
        {
            this.AutoSize = true;
            dgv_listBooking.Width = this.Width - 50;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_listBooking.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btnDelete";
            btn.UseColumnTextForButtonValue = true;

            // Custom the header text
            dgv_listBooking.Columns["BookingId"].Visible = false;
            dgv_listBooking.Columns["CustomerId"].Visible = false;
            dgv_listBooking.Columns["RoomId"].Visible = false;

            // Add event handler for the button
            dgv_listBooking.CellClick += new DataGridViewCellEventHandler(this.dgv_listBooking_CellClick);
        }

        private void dgv_listBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_listBooking.Columns["btnDelete"].Index)
            {
                var Booking = dgv_listBooking.Rows[e.RowIndex].DataBoundItem as Booking;
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _context.Bookings.Remove(Booking);
                    _context.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                var Booking = dgv_listBooking.Rows[e.RowIndex].DataBoundItem as Booking;
                _selectedBooking = Booking;
                cbx_customer.SelectedValue = Booking.CustomerId;
                cbx_room.SelectedValue = Booking.RoomId;
                dp_checkin.Value = Booking.CheckInDate.Value;
                dp_checkout.Value = Booking.CheckOutDate.Value;
                txt_Price.Text = Booking.TotalPrice.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbx_customer.SelectedIndex == -1 || cbx_room.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Customer and Room");
                return;
            }

            var booking = new Booking
            {
                CustomerId = (int)cbx_customer.SelectedValue,
                RoomId = (int)cbx_room.SelectedValue,
                CheckInDate = dp_checkin.Value,
                CheckOutDate = dp_checkout.Value,
                TotalPrice = double.Parse(txt_Price.Text)
            };
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedBooking == null)
            {
                MessageBox.Show("Please select a Booking to edit");
                return;
            }

            if (cbx_customer.SelectedIndex == -1 || cbx_room.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Customer and Room");
                return;
            }

            _selectedBooking.CustomerId = (int)cbx_customer.SelectedValue;
            _selectedBooking.RoomId = (int)cbx_room.SelectedValue;
            _selectedBooking.CheckInDate = dp_checkin.Value;
            _selectedBooking.CheckOutDate = dp_checkout.Value;
            _selectedBooking.TotalPrice = double.Parse(txt_Price.Text);
            _context.Bookings.Update(_selectedBooking);
            _context.SaveChanges();
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //build dynamic query
            var bookings = _context.Bookings.Include(b => b.Customer).Include(b => b.Room).AsQueryable();
            if (cbx_customer.SelectedIndex != -1)
            {
                bookings = bookings.Where(b => b.CustomerId == (int)cbx_customer.SelectedValue);
            }

            if (cbx_room.SelectedIndex != -1)
            {
                bookings = bookings.Where(b => b.RoomId == (int)cbx_room.SelectedValue);
            }

            dgv_listBooking.DataSource = bookings.ToList();
        }

        private void btn_Referesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
