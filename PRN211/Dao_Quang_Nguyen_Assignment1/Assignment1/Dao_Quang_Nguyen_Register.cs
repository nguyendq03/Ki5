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
    public partial class Register : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)=> Close();


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string city = txtCity.Text;
            bool gender = rbMale.Checked;
            DateTime dob = dtDOB.Value;
            if (!checkValidUser(username))
            {
                MessageBox.Show("Username already exist in database", "Register failed");
            }
            else
            {
                try
                {
                    string sql = $"insert into [User] values('{username}','{password}','{fullname}','{email}','{gender}',{DateOnly.FromDateTime(dob)},'{city}',1)";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Register failed");
                }

            }
        }
        private bool checkValidUser(string username)
        {
            User user = null;
            string sql = $"select * from [User] where Username = '{username}'";
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new User
                    {
                        UserId = reader.GetInt32("UserID"),
                    };
                }
                if (user != null)
                {
                    return false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error at connect database");
            }


            return true;
        }
    }
}
