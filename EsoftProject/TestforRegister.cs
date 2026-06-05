using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject
{
    public partial class TestforRegister : Form
    {
        public TestforRegister()
        {
            InitializeComponent();
        }

        private void TestforRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
           
            //code for finish button

            if (checkBox2.Checked == true && checkBox7.Checked == true && checkBox9.Checked == true && checkBox16.Checked == true && checkBox19.Checked == true)
            {
                    MessageBox.Show("You have pass the exam!Now you can Register as a Student!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                StudentRegister studentRegister = new StudentRegister();
                studentRegister.Show();



            }
            else
            {
                    MessageBox.Show("Low marks try again!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Login_Student login_Student = new Login_Student();
            login_Student.Show();
            this.Close();
        }
    }
}
