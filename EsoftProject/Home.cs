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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //code for choose a path from combobox
            if (comboBox1.SelectedIndex == 0)
            {
                Teacher login_Teacher = new Teacher();
                login_Teacher.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Login_Parent login_Parent = new Login_Parent();
                login_Parent.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Login_Student login_Student = new Login_Student();
                login_Student.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //code for exit
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
