using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading_system
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1(string username)
        {
            InitializeComponent();
            conn = new SqlConnection("Server=LAPTOP-OLJP7E8C;Database=student_grading_system;Integrated Security=True;");
            userlb1.Text = "User: " + username;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        public void FillData1()
        {
            string query = "select * from Student";
            
            DataTable tbl = new DataTable();
           
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            
            ad.Fill(tbl);
            
            dataGridView1.DataSource = tbl;
            
            conn.Close();
        }

        public void FillData2()
        {
            
            string query = "select * from Assignment";
         
            DataTable tbl = new DataTable();
          
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
         
            ad.Fill(tbl);
     
            dataGridView2.DataSource = tbl;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open(); // Open the database connection

            if (tabControl1.SelectedTab == tabPage1)
            {
                FillData1 ();
                FillData2();
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
