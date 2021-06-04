using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documentation_Management_System_Mobitel
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Customer WHERE MobileNumber = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            string qry2 = "DELETE FROM Customer WHERE MobileNumber = '" + textBox1.Text + "'";
            SqlCommand cmd2 = new SqlCommand(qry2, con);

            //string qry = "UPDATE Customer SET UserName = '" + textBox2.Text + "', E-Mail = '" + textBox3.Text + "', Password = '" + textBox4.Text + "' WHERE MobileNumber = '" + textBox1.Text + "'";
            string qry3 = "INSERT INTO Customer VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd3 = new SqlCommand(qry3, con);


            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && sdr.Read())
                {
                    con.Close();
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("Update Sucessfull");

                }
                else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    MessageBox.Show("Mobile Number does not exist");
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
    }
}
