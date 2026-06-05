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
    public partial class ParentNote : Form
    {
        SqlConnection conn=new SqlConnection();
        public ParentNote()
        {
            //connect database
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
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
            ParentMenu parentMenu = new ParentMenu();
            parentMenu.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //code for save note
            try
            {
                conn.Open();

                String Query = "INSERT INTO NoteParents (Date,Note) VALUES ('" + dateTimePicker1.Value.Date.ToString() + "','" + txtnote.Text + "')";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, conn);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Note saved successfull!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all
            txtnote.Clear();
            dateTimePicker1.ResetText();
            txtnote.Focus();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //code for search note
            try
            {


                conn.Open();

                String Select = "SELECT*FROM NoteParents WHERE Date = '" + dateTimePicker1.Value.Date.ToString() + "'";
                SqlCommand comm = new SqlCommand(Select, conn);

                SqlDataReader SR = comm.ExecuteReader();
                while (SR.Read())
                {
                    txtnote.Text = SR.GetValue(1).ToString();
                }

                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //code for delete note
            if (txtnote.Text == "")
            {
                MessageBox.Show("Haven't found note for delete!");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        String DeleteQuery = "DELETE FROM NoteParents WHERE Date='" + dateTimePicker1.Value.Date.ToString() + "'";
                        SqlCommand comm = new SqlCommand(DeleteQuery, conn);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting!" + ex);
                }
                finally
                {
                    txtnote.Clear();
                    dateTimePicker1.ResetText();
                    txtnote.Focus();

                }
            }
        }
    }
}
