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
    public partial class MarksEnterTeacher : Form
    {
        SqlConnection conn=new SqlConnection();
        public MarksEnterTeacher()
        {
            //connect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void MarksEnterTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //code for input marks from submit button
            try
            {
                conn.Open();
                    
                    string aQuery = "INSERT INTO Marks (IndexNo,Mathematics,Science,Sinhala,Buddhism,History,English) VALUES ('" + txtIndexNo.Text + "','" + txtMaths.Text + "','" + txtScience.Text + "'," +
                        "'" + txtSinhala.Text + "','" + txtBuddhism.Text + "','" + txtHistory.Text + "','" + txtEnglish.Text + "')";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(aQuery, conn);
                    sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                //code for progressbar
                progressBar1.Value = progressBar1.Value + 100;
                    MessageBox.Show("Marks Input Successfully!");
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
            finally
            {
                progressBar1.Value = 0;
                txtIndexNo.Clear();
                txtBuddhism.Clear();
                txtEnglish.Clear();
                txtHistory.Clear();
                txtMaths.Clear();
                txtScience.Clear();
                txtSinhala.Clear();
                txtIndexNo.Focus();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            TeacherMenu menu = new TeacherMenu();
            menu.Show();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
