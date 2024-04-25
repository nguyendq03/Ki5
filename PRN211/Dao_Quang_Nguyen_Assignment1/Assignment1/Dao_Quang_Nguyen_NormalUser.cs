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
    public partial class _13_NguyenQuangSu_NormalUser : Form
    {
        public User user = new User();

        BindingSource source;
        public _13_NguyenQuangSu_NormalUser()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            _13_NguyenQuangSu_ViewProfile viewProfile = new _13_NguyenQuangSu_ViewProfile
            {
                u = user
            };
            if (viewProfile.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _13_NguyenQuangSu_EditProfile editProfile = new _13_NguyenQuangSu_EditProfile
            {
                u = user
            };
            if (editProfile.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
