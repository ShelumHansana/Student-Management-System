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
    public partial class AgreementforParent : Form
    {
        public AgreementforParent()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //code for accept button
            ParentRegister parentRegister = new ParentRegister();
            parentRegister.Show();
            this.Hide();
        }
    }
}
