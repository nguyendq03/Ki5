using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class _13_NguyenQuangSu_Search : Form
    {
        string ConnectionString = "Server=LAPTOP-GVNBRE21;uid=sa;pwd=123456789;" +
            "database=13_NguyenQuangSu_Assignment1;TrustServerCertificate=True;";
        public string searchItem = null;
        public _13_NguyenQuangSu_Search()
        {
            InitializeComponent();
        }
        private void Search_Load(object sender, EventArgs e)
        {
            lbSearchItem.Text =searchItem;
        }

        public DataSet Search()
        {
            DataSet search = new DataSet();
            string sql = $"select * from [User] where {searchItem} like '%{txtSearch.Text}%'";
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ConnectionString);
            adapter.Fill(search);
            search.Tables[0].Columns.Remove("RoleID");
            return search;
        }
        private void btnBack_Click(object sender, EventArgs e)=> Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            Hide();
            
        }


    }
}
