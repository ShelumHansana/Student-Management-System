using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //use sql server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject
{
    public partial class IndexNoCheckerforStudent : Form
    {
        SqlConnection conn=new SqlConnection();
        public IndexNoCheckerforStudent()
        {
            //connect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            Login_Student student = new Login_Student();
            student.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //exit button
            DialogResult dialogResult = MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                Home home = new Home();
                home.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //code for next button
            try
            {
                conn.Open();

                string index = txtindexno.Text;

                string Query = "SELECT*from registerform WHERE IndexNo='" + index + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    MessageBox.Show("Index Checking Successfull!", "Index Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    TestforRegister testforRegister = new TestforRegister();
                    testforRegister.Show();

                }
                else
                {
                    MessageBox.Show("Haven't this Index No!", "Index Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
            finally
            {
               txtindexno.Clear();
            }
        }

        private void IndexNoCheckerforStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
