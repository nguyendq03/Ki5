using Microsoft.Data.SqlClient;
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
    public partial class _13_NguyenQuangSu_Delete : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        public _13_NguyenQuangSu_Delete()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse(txtUserID.Text);
            DialogResult result = MessageBox.Show($"Do you want to delete user with UserID = {UserID}", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                try
                {
                    string sql = $"delete [User] where UserID = {UserID}";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int x=  cmd.ExecuteNonQuery();
                    if(x != 0)
                    {
                        MessageBox.Show($"Delete user with UserID = {UserID}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete");
                }

            }

        }


    }
}
