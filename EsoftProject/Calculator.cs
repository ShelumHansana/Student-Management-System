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
    public partial class Calculator : Form
    {
        //create variables
        double x, y, z;
        public Calculator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
            this.Close();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            //code for subtraction
            txtmark.Text = "-";
            x = double.Parse(txtnum1.Text);
            y = double.Parse(txtnum2.Text);
            z = x - y;
            txtanswer.Text = z.ToString();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            //code for multiplication
            txtmark.Text = "X";
            x = double.Parse(txtnum1.Text);
            y = double.Parse(txtnum2.Text);
            z = x * y;
            txtanswer.Text = z.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            //code for division
            txtmark.Text = "/";
            x = double.Parse(txtnum1.Text);
            y = double.Parse(txtnum2.Text);
            z = x / y;
            txtanswer.Text = z.ToString();
        }

        private void btnpct_Click(object sender, EventArgs e)
        {
            //code for percentage
            txtmark.Text = "%";
            x = double.Parse(txtnum1.Text);
            y = double.Parse(txtnum2.Text);
            z = (x / y)*100;
            txtanswer.Text = z.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //code for clear
            txtanswer.Clear();
            txtnum1.Clear();
            txtnum2.Clear();
            txtmark.Clear();
            txtnum1.Focus();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txtanswer.Enabled = false;
            txtmark.Enabled = false;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            //code for addition
            txtmark.Text = "+";
            x=double.Parse(txtnum1.Text);
            y=double.Parse(txtnum2.Text);
            z = x + y;
            txtanswer.Text=z.ToString();
        }
    }
}
