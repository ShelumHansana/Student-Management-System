using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //use sql server
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EsoftProject
{
    public partial class StudentProgress : Form
    {
        
        SqlConnection conn = new SqlConnection();

        //create variables
        double tot, pct;
        public StudentProgress()
        {
            //connect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //code for view marks from submit button
            try
            {
               
                
                conn.Open();

                String Select = "SELECT*FROM Marks WHERE IndexNo = '" + txtIndexNo.Text + "'";
                SqlCommand comm = new SqlCommand(Select, conn);

                SqlDataReader SR = comm.ExecuteReader();
                while (SR.Read())
                {
                    txtMaths.Text = SR.GetValue(1).ToString();
                    txtScience.Text = SR.GetValue(2).ToString();
                    txtSinhala.Text = SR.GetValue(3).ToString();
                    txtBuddhism.Text = SR.GetValue(4).ToString();
                    txtHistory.Text = SR.GetValue(5).ToString();
                    txtEnglish.Text = SR.GetValue(6).ToString(); 
                }
              

                conn.Close();

                double a = Convert.ToDouble(txtMaths.Text);
                double b = Convert.ToDouble(txtScience.Text);
                double c = Convert.ToDouble(txtSinhala.Text);
                double d = Convert.ToDouble(txtBuddhism.Text);
                double f = Convert.ToDouble(txtHistory.Text);
                double g = Convert.ToDouble(txtEnglish.Text);

                tot = a + b + c + d + f + g;
                txtTot.Text = tot.ToString();

                pct = tot / 6;
                txtPct.Text = pct.ToString();

                progressBar1.Value = Convert.ToInt32(progressBar1.Value) + 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect INDEX NUMBER!" + ex);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all
            progressBar1.Value = 0;
            txtBuddhism.Clear();
            txtHistory.Clear();
            txtEnglish.Clear();
            txtTot.Clear();
            txtPct.Clear();
            txtSinhala.Clear();
            txtScience.Clear();
            txtMaths.Clear();
            txtIndexNo.Clear();
            txtIndexNo.Focus();

        }

        private void StudentProgress_Load(object sender, EventArgs e)
        {
            //disable inputs for subject's textboxes
            txtBuddhism.Enabled = false;
            txtHistory.Enabled = false;
            txtEnglish.Enabled = false;
            txtTot.Enabled = false;
            txtPct.Enabled = false;
            txtSinhala.Enabled = false;
            txtScience.Enabled = false;
            txtMaths.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            StudentMenu menu = new StudentMenu();
            menu.Show();
            this.Close();
        }
    }
}
