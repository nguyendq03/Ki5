using DataAccess.Models;
using System.Data;

namespace HotelManagement
{
    public partial class frm_Room : frm_base
    {
        HotelManagementSystemContext _context;
        List<Room> _rooms;
        Room _selectedRoom;

        public frm_Room(HotelManagementSystemContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void frm_listRoom_Load(object sender, EventArgs e)
        {


            LoadData();
            CustomGrid();
        }

        private void LoadData()
        {
            _rooms = _context.Rooms.ToList();
            dgv_listRoom.DataSource = _rooms;
            dgv_listRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbx_roomType.DataSource = _rooms.Select(r => r.RoomType).Distinct().ToList();
            cbx_roomType.SelectedIndex = -1;

            cbx_status.DataSource = _rooms.Select(r => r.Status).Distinct().ToList();
            cbx_status.SelectedIndex = -1;

            txt_Price.Text = "";
        }

        private void CustomGrid()
        {
            this.AutoSize = true;
            dgv_listRoom.Width = this.Width - 50;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_listRoom.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btnDelete";
            btn.UseColumnTextForButtonValue = true;

            // Custom the header text
            dgv_listRoom.Columns["RoomId"].Visible = false;
            dgv_listRoom.Columns["Bookings"].Visible = false;

            // Add event handler for the button
            dgv_listRoom.CellClick += new DataGridViewCellEventHandler(this.dgv_listRoom_CellClick);
        }

        private void dgv_listRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_listRoom.Columns["btnDelete"].Index)
            {
                var room = dgv_listRoom.Rows[e.RowIndex].DataBoundItem as Room;
                var booking = _context.Bookings.FirstOrDefault(b => b.RoomId == room.RoomId);
                if (booking != null)
                {
                    MessageBox.Show("This room is in use, you can not delete it");
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _context.Rooms.Remove(room);
                    _context.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                var room = dgv_listRoom.Rows[e.RowIndex].DataBoundItem as Room;
                _selectedRoom = room;
                txt_Price.Text = room.Price.ToString();
                cbx_roomType.Text = room.RoomType;
                cbx_status.Text = room.Status;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                RoomType = cbx_roomType.Text,
                Status = cbx_status.Text,
                Price = Convert.ToDouble(txt_Price.Text)
            };
            _context.Rooms.Add(room);
            _context.SaveChanges();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedRoom == null)
            {
                MessageBox.Show("Please select a room to edit");
                return;
            }

            _selectedRoom.RoomType = cbx_roomType.Text;
            _selectedRoom.Status = cbx_status.Text;
            _selectedRoom.Price = Convert.ToDouble(txt_Price.Text);
            _context.SaveChanges();
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var rooms = _context.Rooms.ToList();
            if (!string.IsNullOrEmpty(cbx_roomType.Text))
            {
                rooms = rooms.Where(r => r.RoomType == cbx_roomType.Text).ToList();
            }
            if (!string.IsNullOrEmpty(cbx_status.Text))
            {
                rooms = rooms.Where(r => r.Status == cbx_status.Text).ToList();
            }
            dgv_listRoom.DataSource = rooms;
        }

        private void btn_Referesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
