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
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
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
                Teacher teacher = new Teacher();
                teacher.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            this.Close();
            Teacher teacher =new Teacher();
            teacher.Show();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //go to register
            this.Hide();
            RegisterationForm register = new RegisterationForm();
            register.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //go to search 
            this.Hide();
            RegisterationForm register = new RegisterationForm();
            register.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //go to update 
            this.Hide();
            RegisterationForm register = new RegisterationForm();
            register.Show();
        }

        private void btnmarks_Click(object sender, EventArgs e)
        {
            //go to input marks
            this.Hide();
            MarksEnterTeacher marksEnterTeacher = new MarksEnterTeacher();
            marksEnterTeacher.Show();
        }
    }
}
