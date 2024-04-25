using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class_Dao_Quang_Nguyen_MembersManagement : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        BindingSource source;
        DataSet user = new DataSet();
        public_Dao_Quang_Nguyen_MembersManagement()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            if(register.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
            loadUser();
        }

        private void loadUser()
        {
            user.Clear();
            string sql = "select * from [User] where RoleID = 1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,ConnectionString);
            adapter.Fill(user);
            user.Tables[0].Columns.Remove("RoleID");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadUser();
            dgvUser.DataSource = user.Tables[0];
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUser.SelectedRows[0];
               _Dao_Quang_Nguyen_EditProfile edit = new_Dao_Quang_Nguyen_EditProfile
                {
                    u = new User
                    {
                        UserId = Convert.ToInt32(selectedRow.Cells[0].Value),
                        UserName = selectedRow.Cells[1].Value.ToString(),
                        Password = selectedRow.Cells[2].Value.ToString(),
                        Fullname = selectedRow.Cells[3].Value.ToString(),
                        Email = selectedRow.Cells[4].Value.ToString(),
                        Gender = Convert.ToBoolean(selectedRow.Cells[5].Value),
                        DateOfBirth = Convert.ToDateTime(selectedRow.Cells[6].Value),
                        City = selectedRow.Cells[7].Value.ToString()
                    }
                };
                if(edit.ShowDialog() == DialogResult.OK)
                {
                    source.Position = source.Count - 1;
                }
            }
            loadUser();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           _Dao_Quang_Nguyen_Delete del = new_Dao_Quang_Nguyen_Delete();
            if(del.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
            loadUser();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string city = null, gender = null;

            if(cbFilterCity.SelectedItem!= null)
            {
                city = cbFilterCity.SelectedItem.ToString();
            }
            if(cbFilterGender.SelectedItem!= null)
            {
                gender = cbFilterGender.SelectedItem.ToString();
                gender = gender.Equals("Male") ? "true" : "false";
            }

            string sql = "select * from [User] where ";
            if (city != null)
            {
                sql += $"City = N'{city}' and ";  
            }
            if (gender != null)
            {
                sql += $"Gender = '{gender}' and ";
            }
            
            
            sql =sql .Substring(0,sql.Length-4);
            
            user.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ConnectionString);
            adapter.Fill(user);
            user.Tables[0].Columns.Remove("RoleID");
            dgvUser.DataSource = user.Tables[0];
        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
           _Dao_Quang_Nguyen_Search search = new_Dao_Quang_Nguyen_Search
            {
                searchItem = cbSearchBy.SelectedItem.ToString()
            };
            if (search.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
            dgvUser.DataSource = search.Search().Tables[0];
            search.Close();
        }
    }
}
