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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        public double ServiceCharge;
        public double paidamount, returnamount;
        public double netamount;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Transactions";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Transactions");
            dataGridView1.DataSource = ds.Tables["Transactions"];
        }
        public void Calculation()
        {
            double paidamount, returnamount;
            paidamount = double.Parse(textBox6.Text);

            returnamount = paidamount - netamount;
             textBox8.Text = "" + returnamount.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Calculation();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*int Sname = int.Parse(textBox5.Text);
            string scharge = textBox5.Text;
            textBox6.Text = "" + netamount.ToString();
            textBox6.Text = "" + ServiceCharge.ToString();
            netamount = ServiceCharge * 0.9;
            textBox6.Text = "" + netamount.ToString();
            textBox6.Text = ""+textBox5.Text.ToString();*/
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            var qry = "INSERT INTO Transactions (CustName, CustEmail, CustMobile, ServName, ServCharge) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {

                if (textBox3.Text != "" && textBox5.Text != "")
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transation Sucessfull");
                    string qry2 = "SELECT * FROM Transactions";
                    SqlDataAdapter sda = new SqlDataAdapter(qry2, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Transactions");
                    dataGridView1.DataSource = ds.Tables["Transactions"];
                }
                else
                {
                    MessageBox.Show("CustomerMobile and ServiceCharge fields are mandatory");
                }


            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
