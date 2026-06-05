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
    public partial class RegisterationForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds;
        string gender;
       
        public RegisterationForm()
        {
            //connect database 
            conn.ConnectionString = @"Data Source=DESKTOP-EGEBLSD;Initial Catalog=sh2002;Integrated Security=True";
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //back button
            this.Close();
            TeacherMenu menu = new TeacherMenu();
            menu.Show();
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

        //details load from database to datagridview
        public void details_load()
        {
            try
            {
                conn.Open();

                dataGridView1.Visible = true;

                sda = new SqlDataAdapter("SELECT*FROM registerform",conn);
                ds=new System.Data.DataSet();

                sda.Fill(ds, "registerform");
                dataGridView1.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        //load details and genarate indexno while open form
        private void RegisterationForm_Load(object sender, EventArgs e)
        {
            details_load();

            load_IndexNo();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //code for insert button
            if (txtindexno.Text == "" || txtnamefull.Text == "" || txtnameinitials.Text == "" || txtparent.Text == "" || txtnic.Text == "" || txtcontact.Text == "" || txttel.Text == "" || txtmob.Text == "" || txtaddress.Text == "" || rbnmale.Checked == false && rbnfemale.Checked == false)
            {
                MessageBox.Show("Fill all the details!","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (rbnmale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (rbnfemale.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Select gender!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Open();

                    String AddQuery = "INSERT INTO registerform (IndexNo,NameinFull,NameWithInitials,Birthday,Gender,ParentName,NICnumber,ContactNo,TelNo,MobNo,Address) VALUES " +
                        "('" + txtindexno.Text + "','" + txtnamefull.Text + "','" + txtnameinitials.Text + "','" + dtpbday.Value.Date.ToString() + "','" + gender + "','" + txtparent.Text + "'," +
                        "'" + txtnic.Text + "','" + txtcontact.Text + "','" + txttel.Text + "','" + txtmob.Text + "','" + txtaddress.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(AddQuery, conn);
                    SDA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Register successfuly!");

                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while adding!" + ex);
                }
                finally
                {
                    txtindexno.Clear();
                    txtnamefull.Clear();
                    txtnameinitials.Clear();
                    txtnic.Clear();
                    txtcontact.Clear();
                    txttel.Clear();
                    txtparent.Clear();
                    txtmob.Clear();
                    txtaddress.Clear();
                    rbnmale.Checked = false;
                    rbnfemale.Checked = false;
                    comboBox1.Text = "- - -SELECT INDEX No- - -";
                    dtpbday.ResetText();

                    details_load();

                    txtnamefull.Focus();
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code for combobox to search details
            try
            {
                String SIst=comboBox1.SelectedItem.ToString();

                conn.Open();

                String Select = "SELECT*FROM registerform WHERE IndexNo = '" + SIst + "'";
                SqlCommand comm = new SqlCommand(Select, conn);

                SqlDataReader SR = comm.ExecuteReader();
                while (SR.Read())
                {
                    txtindexno.Text = SR.GetValue(0).ToString();
                    txtnamefull.Text = SR.GetValue(1).ToString();
                    txtnameinitials.Text = SR.GetValue(2).ToString();
                    dtpbday.Value = (DateTime)SR["Birthday"];
                    txtparent.Text = SR.GetValue(5).ToString();
                    txtnic.Text = SR.GetValue(6).ToString();
                    txtcontact.Text = SR.GetValue(7).ToString();
                    txttel.Text = SR.GetValue(8).ToString();
                    txtmob.Text = SR.GetValue(9).ToString();
                    txtaddress.Text = SR.GetValue(10).ToString();
                    gender=SR.GetValue(4).ToString();

                    if(gender =="Male")
                    {
                        rbnmale.Checked=true;
                    }
                    else if(gender =="Female")
                    {
                        rbnfemale.Checked=true;
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load data for selected items!" + ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //code search button
            try
            {
                comboBox1.Items.Clear();

                conn.Open();

                String Search = "SELECT IndexNo FROM registerform ORDER BY IndexNo";
                sda = new SqlDataAdapter(Search, conn);
                DataTable DT = new DataTable();
                sda.Fill(DT);

                conn.Close();

                comboBox1.Items.Add("- - -SELECT INDEX No- - -");
                foreach(DataRow row in DT.Rows)
                {
                    comboBox1.Items.Add(row["IndexNo"]);
                }
                comboBox1.SelectedIndex = 0;
                comboBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching data!" + ex);
            }

            conn.Close(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //code for update button
            if(txtindexno.Text=="")
            {
                MessageBox.Show("Haven't found data to update!");
            }
            else
            {
                try
                {
                    if(rbnmale.Checked==true)
                    {
                        gender = "Male";
                    }
                    else if(rbnfemale.Checked==true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Select gender!");
                    }

                    DialogResult result = MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        String UpdateQuery = "UPDATE registerform SET NameinFull='" + txtnamefull.Text + "',NameWithInitials='" + txtnameinitials.Text + "',Birthday='" + dtpbday.Value.Date.ToString() + "'," +
                            "Gender='" + gender + "',ParentName='" + txtparent.Text + "',NICnumber='" + txtnic.Text + "',ContactNo='" + txtcontact.Text + "',TelNo='" + txttel.Text + "',MobNo='" + txtmob.Text + "',Address='" + txtaddress.Text + "' " +
                            "WHERE IndexNo='" + txtindexno.Text + "'";
                        SqlCommand comm = new SqlCommand(UpdateQuery, conn);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Update successful!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while updating!" + ex);
                }
                finally
                {
                    txtindexno.Clear();
                    txtnamefull.Clear();
                    txtnameinitials.Clear();
                    txtnic.Clear();
                    txtcontact.Clear();
                    txttel.Clear();
                    txtparent.Clear();
                    txtmob.Clear();
                    txtaddress.Clear();
                    rbnmale.Checked = false;
                    rbnfemale.Checked = false;
                    comboBox1.Text = "- - -SELECT INDEX No- - -";
                    dtpbday.ResetText();

                    details_load();

                    txtnamefull.Focus();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //code for delete button
            if(txtindexno.Text=="")
            {
                MessageBox.Show("Haven't found data for delete!");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        String DeleteQuery = "DELETE FROM registerform WHERE IndexNo='" + txtindexno.Text + "'";
                        SqlCommand comm = new SqlCommand(DeleteQuery, conn);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show("Error while deleting!" + ex);
                }
                finally
                {
                    txtindexno.Clear();
                    txtnamefull.Clear();
                    txtnameinitials.Clear();
                    txtnic.Clear();
                    txtcontact.Clear();
                    txttel.Clear();
                    txtparent.Clear();
                    txtmob.Clear();
                    txtaddress.Clear();
                    rbnmale.Checked = false;
                    rbnfemale.Checked = false;
                    comboBox1.Text = "- - -SELECT INDEX No- - -";
                    dtpbday.ResetText();

                    details_load();

                    txtnamefull.Focus();
                }
            }
        }

        //code for auto genarate index number
        private void load_IndexNo()
        {
            String indexno = "SELECT IndexNo FROM registerform";
            conn.Open();
            sda = new SqlDataAdapter(indexno, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 0 )
            {
                txtindexno.Text = "SIst000001";
            }
            else if(dt.Rows.Count > 0)
            {
                String id = "SELECT MAX(IndexNo) FROM registerform";
                SqlCommand comm = new SqlCommand(id, conn);
                SqlDataReader sr = comm.ExecuteReader();
                while(sr.Read())
                {
                    string input = sr.GetString(0).ToString();
                    string a = input.Substring(input.Length - Math.Min(6, input.Length));
                    int ID = Convert.ToInt32(a);
                    ID += 1;
                    string b = ID.ToString("D6");

                    txtindexno.Text = "SIst" + b;
                }
            }
            conn.Close();
        }

        //data validation for nic number
        private void txtnic_TextChanged(object sender, EventArgs e)
        {
            if (txtnic.TextLength == 10 || txtnic.TextLength == 12)
            {
                txtnic.ForeColor = Color.Red;
            }
            else
            {
                txtnic.ForeColor = Color.Black;
            }
        }

        private void txtnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if(!char.IsDigit(a) && a!=8 && a!=86)
            {
                e.Handled = true;
            }
        }

        //code for clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtindexno.Clear();
            txtnamefull.Clear();
            txtnameinitials.Clear();
            txtnic.Clear();
            txtcontact.Clear();
            txttel.Clear();
            txtparent.Clear();
            txtmob.Clear();
            txtaddress.Clear();
            rbnmale.Checked = false;
            rbnfemale.Checked = false;
            comboBox1.Text = "- - -SELECT INDEX No- - -";
            dtpbday.ResetText();

            details_load();

            txtnamefull.Focus();
        }

        //validation for contact number
        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            if (txtcontact.TextLength == 10)
            {
                txtcontact.ForeColor = Color.Blue;
            }
            else
            {
                txtcontact.ForeColor = Color.Black;
            }
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!char.IsDigit(a) && a != 8 && a != 86)
            {
                e.Handled = true;
            }
        }

        //validation for telephone number
        private void txttel_TextChanged(object sender, EventArgs e)
        {
            if (txttel.TextLength == 10)
            {
                txttel.ForeColor = Color.Blue;
            }
            else
            {
                txttel.ForeColor = Color.Black;
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!char.IsDigit(a) && a != 8 && a != 86)
            {
                e.Handled = true;
            }
        }

        //validation for mobile number
        private void txtmob_TextChanged(object sender, EventArgs e)
        {
            if (txtmob.TextLength == 10)
            {
                txtmob.ForeColor = Color.Blue;
            }
            else
            {
                txtmob.ForeColor = Color.Black;
            }
        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!char.IsDigit(a) && a != 8 && a != 86)
            {
                e.Handled = true;
            }
        }
    }
}
