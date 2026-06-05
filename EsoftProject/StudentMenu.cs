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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            //go to view marks
            StudentProgress studentProgress = new StudentProgress();
            studentProgress.Show();
            this.Hide();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //calculator
            Calculator calculator = new Calculator();
            calculator.Show();
            this.Hide();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            //goto note
            StudentNote studentNote = new StudentNote();
            studentNote.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            Login_Student login_Student = new Login_Student();
            login_Student.Show();
            this.Hide();
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
    }
}
