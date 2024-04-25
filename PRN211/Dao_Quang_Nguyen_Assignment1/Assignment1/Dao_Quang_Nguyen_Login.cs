using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
namespace Assignment1
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        

        BindingSource source;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            User user = null;
            string sql = $"select FullName,Email,Gender,DateOfBirth,RoleID,City " +
                $"from [User] where Username = '{txtUsername.Text}' and [Password] = '{txtPassword.Text}'";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                user = new User
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Fullname = reader.GetString("FullName"),
                    Email = reader.GetString("Email"),
                    Gender = reader.GetBoolean("Gender"),
                    DateOfBirth = reader.GetDateTime("DateOfBirth"),
                    City = reader.GetString("City"),
                    RoleID = reader.GetInt32("RoleID")
                };
            }
            if (user == null)
            {
                MessageBox.Show("Login failed");
            }
            else if (user.RoleID == 1)
            {
                this.Hide();
                _13_NguyenQuangSu_NormalUser normalUser = new _13_NguyenQuangSu_NormalUser
                {
                    user = user
                };
                normalUser.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                _13_NguyenQuangSu_MembersManagement admin = new _13_NguyenQuangSu_MembersManagement();
                admin.ShowDialog();
                this.Close();
            }



        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            if (register.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
        }
    }
}
