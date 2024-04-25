using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class _13_NguyenQuangSu_ViewProfile : Form
    {
        public User u;
        public _13_NguyenQuangSu_ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = u.Fullname;
            txtEmail.Text = u.Email;
            rbMale.Checked = u.Gender;
            rbFemale.Checked = !rbMale.Checked;
            dtDOB.Value = u.DateOfBirth;
            txtCity.Text = u.City;
        }

        private void btnBack_Click(object sender, EventArgs e)=> Close();
       
    }
}
