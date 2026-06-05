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
    public partial class ParentMenu : Form
    {
        public ParentMenu()
        {
            InitializeComponent();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            //go to view marks
           MarksParent marksParent = new MarksParent();
            marksParent.Show();
            this.Hide();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            //go to note
            ParentNote note = new ParentNote();
            note.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            //view contact numbers with messagebox
            MessageBox.Show("Teacher-0771234567"+Environment.NewLine+"Administration Office-0911234567","Contact Numbers",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            Login_Parent login_Parent = new Login_Parent();
            login_Parent.Show();
            this.Close();
        }
    }
}
