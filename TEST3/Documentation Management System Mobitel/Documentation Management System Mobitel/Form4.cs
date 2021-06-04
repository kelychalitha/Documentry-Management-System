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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Customer WHERE UserName = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    //MessageBox.Show("Login Sucessfull");
                    CustomerHome f3 = new CustomerHome();
                    f3.Show();
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Register f1 = new Register();
            f1.Show();
        }
    }
}
