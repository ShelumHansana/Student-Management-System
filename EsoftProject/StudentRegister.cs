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
    public partial class StudentRegister : Form
    {
        SqlConnection conn=new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public StudentRegister()
        {
            //connect databse
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //back button
            Login_Student student = new Login_Student();
            student.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pbRegisterbtn_Click(object sender, EventArgs e)
        {
            //code for signup 
            if (txtusername.Text == "" || txtpassword.Text == "" || txtconformpassword.Text == "" || txtpassword.Text != txtconformpassword.Text)
            {
                MessageBox.Show("Filling Error Or Blank Error");
            }
            else
            {
                try
                {
                    conn.Open();
                    
                  

                    string Query = "INSERT INTO Students (username,password) VALUES ('" + txtusername.Text + "','" + txtconformpassword.Text + "')";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, conn);
                    sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successfuly!");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding!" + ex);
                }
                finally
                {
                    
                    txtusername.Clear();
                    txtconformpassword.Clear();
                    txtpassword.Clear();
                    
                    this.Close();
                    Login_Student login = new Login_Student();
                    login.Show();
                }
            }
        }
    }
}
