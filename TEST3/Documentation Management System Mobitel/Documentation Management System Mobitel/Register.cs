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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO Customer VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"')";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox4.Text == textBox5.Text)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Sucessfull");
                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
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

        private void Txtbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
               
        }
    }
}
