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
    public partial class ParentRegister : Form
    {
        SqlConnection conn=new SqlConnection();
        SqlDataAdapter adapter=new SqlDataAdapter();
        public ParentRegister()
        {
            //connect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            //back button
            Login_Parent parent = new Login_Parent();
            parent.Show();
            this.Close();
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

        private void pbRegisterbtn_Click(object sender, EventArgs e)
        {
            //code for register button
            if (txtusername.Text == "" || txtpassword.Text == "" || txtconformpassword.Text == "" || txtpassword.Text != txtconformpassword.Text)
            {
                MessageBox.Show("Filling Error Or Blank Error");
            }
            else
            {
                try
                {
                    conn.Open();

                  

                    string Query = "INSERT INTO Parents (username,password) VALUES ('" + txtusername.Text + "','" + txtconformpassword.Text + "')";
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
                    Login_Parent login = new Login_Parent();
                    login.Show();
                }
            }
        }

        private void ParentRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
