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
using System.Xml.Linq;

namespace Grading_system
{

    public partial class Teacher : Form
    {
        SqlConnection conn;
        public Teacher(string username)
        {
            InitializeComponent();
            conn = new SqlConnection("Server=LAPTOP-OLJP7E8C;Database=student_grading_system;Integrated Security=True;");
            userlb1.Text = "User: " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0;
            string courseid = Coursetbx.Text;
            if (courseid.Equals(""))
            {
                error = error + 1;
                lblerror1.Text = "ID can't be blank";
            }
            else
                lblerror1.Text = "";
            string studentid = studenttbx.Text;
            if (studentid.Equals(""))
            {
                error = error + 1;
                lblerror2.Text = "ID can't be blank";
            }
            else
                lblerror2.Text = "";
            string grade = gradetbx.Text;
            if (grade.Equals(""))
            {
                error = error + 1;
                lblerror3.Text = "Grade can't be blank";
            }
            else
            {
                string query = "Select * from Assignment where CourseID = @courseid and StudentID = @studentid";
                conn.Open();
                SqlCommand cmdcheck = new SqlCommand(query, conn);
                cmdcheck.Parameters.Add("@courseid", SqlDbType.NVarChar,10);
                cmdcheck.Parameters["@courseid"].Value = courseid;
                cmdcheck.Parameters.Add("@studentid", SqlDbType.NVarChar,10);
                cmdcheck.Parameters["@studentid"].Value = studentid;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read() )
                {
                    error++;
                    lblerror1.Text = "Both IDs already exist, please choose another";
                    lblerror2.Text = "Both IDs already exist, please choose another";
                }
                else
                {
                    lblerror2.Text = "";
                    lblerror1.Text = "";
                }
                conn.Close();
            }
            if (error == 0)
            {
                string insert = "insert into Assignment values (@course,@StudentID,@AssignmentGrade)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.Add("@course", SqlDbType.Int);
                cmd.Parameters["@course"].Value = courseid;
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar);
                cmd.Parameters["@StudentID"].Value = studentid;
                cmd.Parameters.Add("@AssignmentGrade", SqlDbType.VarChar);
                cmd.Parameters["@AssignmentGrade"].Value = grade;
 
                cmd.ExecuteNonQuery();
               
                FillData2();
                MessageBox.Show(this, "Inserted sucessfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userlb1_Click(object sender, EventArgs e)
        {

        }
        public void FillData1()
        {
            string query = "select * from Teacher";

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

            dataGridView3.DataSource = tbl;
            conn.Close();
        }

        public void FillData3()
        {

            string query = "select * from Course";

            DataTable tbl = new DataTable();

            SqlDataAdapter ad = new SqlDataAdapter(query, conn);

            ad.Fill(tbl);

            dataGridView2.DataSource = tbl;
            conn.Close();
        }

        public void FillData4()
        {

            string query = "select * from TeacherCourse";

            DataTable tbl = new DataTable();

            SqlDataAdapter ad = new SqlDataAdapter(query, conn);

            ad.Fill(tbl);

            dataGridView4.DataSource = tbl;
            conn.Close();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (tabControl1.SelectedTab == tabPage1)
            {
                FillData1();
                FillData2();
                FillData3();
                FillData4();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studenttbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string update = "UPDATE Assignment SET AssignmentGrade = @assignmentgrade WHERE CourseID = @courseid AND StudentID = @studentid";
                conn.Open();
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@assignmentgrade", SqlDbType.VarChar);
                cmd.Parameters["@assignmentgrade"].Value = gradetbx.Text;
                cmd.Parameters.Add("@courseid", SqlDbType.NVarChar, 10);
                cmd.Parameters["@courseid"].Value = Coursetbx.Text;
                cmd.Parameters.Add("@studentid", SqlDbType.NVarChar, 10);
                cmd.Parameters["@studentid"].Value = studenttbx.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData2();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                Coursetbx.Text = row.Cells["CourseID2"].Value.ToString();
                studenttbx.Text = row.Cells["StudentID"].Value.ToString();
                gradetbx.Text = row.Cells["AssignmentGrade"].Value.ToString();
            }   
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
