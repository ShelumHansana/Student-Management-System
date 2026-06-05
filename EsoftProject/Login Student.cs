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

namespace EsoftProject
{
    public partial class Login_Student : Form
    {
        SqlConnection conn = new SqlConnection();
        public Login_Student()
        {
            //conect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            //enable char
            txtpassword.UseSystemPasswordChar = true;
        }

        private void checkboxpassword_CheckedChanged(object sender, EventArgs e)
        {
            //show password
            if (checkboxpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
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
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Login_Student_Load(object sender, EventArgs e)
        {

        }

        private void linklblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //go to signup from linklable
            this.Hide();
            IndexNoCheckerforStudent indexNoCheckerforStudent = new IndexNoCheckerforStudent();
            indexNoCheckerforStudent.Show();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            //code for login 
            try
            {
                conn.Open();

                string user = txtusername.Text;
                string password = txtpassword.Text;

                string Query = "SELECT*from Students WHERE username='" + user + "' AND password='" + password + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    StudentMenu parentMenu = new StudentMenu();
                    parentMenu.Show();

                }
                else
                {
                    MessageBox.Show("User name or Password Incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
            finally
            {
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }
    }
}
