using DataAccess.Models;

namespace HotelManagement
{
    public partial class frm_Customer : frm_base
    {
        HotelManagementSystemContext _context;
        List<DataAccess.Models.Customer> _customers;
        DataAccess.Models.Customer _selectedCustomer;

        public frm_Customer(HotelManagementSystemContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void frm_listCustomer_Load(object sender, EventArgs e)
        {


            LoadData();
            CustomGrid();
        }

        private void LoadData()
        {
            _customers = _context.Customers.ToList();
            dgv_listCustomer.DataSource = _customers;
            dgv_listCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txt_name.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
        }

        private void CustomGrid()
        {
            this.AutoSize = true;
            dgv_listCustomer.Width = this.Width - 50;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv_listCustomer.Columns.Add(btn);
            btn.HeaderText = "Action";
            btn.Text = "Delete";
            btn.Name = "btnDelete";
            btn.UseColumnTextForButtonValue = true;

            // Custom the header text
            dgv_listCustomer.Columns["CustomerId"].Visible = false;
            dgv_listCustomer.Columns["Bookings"].Visible = false;

            // Add event handler for the button
            dgv_listCustomer.CellClick += new DataGridViewCellEventHandler(this.dgv_listRoom_CellClick);
        }

        private void dgv_listRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_listCustomer.Columns["btnDelete"].Index)
            {
                var customer = dgv_listCustomer.Rows[e.RowIndex].DataBoundItem as DataAccess.Models.Customer;
                var booking = _context.Bookings.FirstOrDefault(b => b.RoomId == customer.CustomerId);
                if (booking != null)
                {
                    MessageBox.Show("This customer has booking, can not delete");
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                var customer = dgv_listCustomer.Rows[e.RowIndex].DataBoundItem as DataAccess.Models.Customer;
                _selectedCustomer = customer;
                txt_name.Text = customer.Name;
                txt_address.Text = customer.Address;
                txt_phone.Text = customer.PhoneNumber;
                txt_email.Text = customer.Email;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var customer = new DataAccess.Models.Customer
            {
                Name = txt_name.Text,
                Address = txt_address.Text,
                PhoneNumber = txt_phone.Text,
                Email = txt_email.Text
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to edit");
                return;
            }
            _selectedCustomer.Name = txt_name.Text;
            _selectedCustomer.Address = txt_address.Text;
            _selectedCustomer.PhoneNumber = txt_phone.Text;
            _selectedCustomer.Email = txt_email.Text;
            _context.SaveChanges();
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var name = txt_name.Text;
            var address = txt_address.Text;
            var phone = txt_phone.Text;
            var email = txt_email.Text;
            _customers = _context.Customers.Where(c => c.Name.Contains(name) && c.Address.Contains(address) && c.PhoneNumber.Contains(phone) && c.Email.Contains(email)).ToList();
            dgv_listCustomer.DataSource = _customers;
        }
        private void btn_Referesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
