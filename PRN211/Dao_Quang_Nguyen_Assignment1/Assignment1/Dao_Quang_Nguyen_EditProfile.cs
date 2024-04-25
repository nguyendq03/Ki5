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
    public partial class _13_NguyenQuangSu_EditProfile : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        public User u;
        public _13_NguyenQuangSu_EditProfile()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            
            string sql = $"select Password,FullName,Email,Gender,DateOfBirth,RoleID,City " +
                $"from [User] where Username = '{u.UserName}'";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                u = new User
                {
                    UserName = u.UserName,
                    Password = reader.GetString("Password"),
                    Fullname = reader.GetString("FullName"),
                    Email = reader.GetString("Email"),
                    Gender = reader.GetBoolean("Gender"),
                    DateOfBirth = reader.GetDateTime("DateOfBirth"),
                    City = reader.GetString("City"),
                    RoleID = reader.GetInt32("RoleID")
                };
            }
            txtName.Text = u.Fullname;
            txtEmail.Text = u.Email;
            txtPassword.Text = u.Password;
            rbMale.Checked = u.Gender;
            rbFemale.Checked = !rbMale.Checked;
            dtDOB.Value = u.DateOfBirth;
            txtCity.Text = u.City;

        }
        private void EditProfile_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnBack_Click(object sender, EventArgs e)=>Close();


        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string city =txtCity.Text;
            string password = txtPassword.Text;
            bool gender = rbMale.Checked?true:false;
            DateTime date = dtDOB.Value;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            try
            {
                string sql = "update [User] set " +
                $"FullName = N'{name}'," +
                $"Email = '{email}'," +
                $"[Password] = '{password}'," +
                $"Gender = '{gender}'," +
                $"DateOfBirth = {DateOnly.FromDateTime(date)},City=N'{city}' where Username = '{u.UserName}'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update successfull","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtEmail.Text = email;
                txtPassword.Text = password;
                txtName.Text = name;
                txtCity.Text = city;
                rbMale.Checked=gender;
                rbFemale.Checked=!rbMale.Checked;
                dtDOB.Value = date;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error at edit profile : {ex.Message}");
            }


        }

        
    }
}
