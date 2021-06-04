using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Documentation_Management_System_Mobitel
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO Admin VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox3.Text == textBox4.Text)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Sucessfull");
                    }
                    else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                    {
                        MessageBox.Show("Password does not match");
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields");
                    }


                }
                catch (Exception se)
                {
                    MessageBox.Show("" + se);
                }
            
               
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Admin WHERE UserName = '" + textBox5.Text + "' AND Password = '" + textBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    //MessageBox.Show("Login Sucessfull");
                    AdminHome f2 = new AdminHome();
                    f2.Show();
                    textBox5.Text = String.Empty;
                    textBox6.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }


            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
