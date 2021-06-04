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
using System.Data.Common.CommandTrees.ExpressionBuilder;

namespace Documentation_Management_System_Mobitel
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Admin adm = new Admin();
            adm.Show();
            this.Hide();*/
            this.Close();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT * FROM Customer ";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TEST3\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM Customer WHERE MobileNumber = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            string qry2 = "SELECT * FROM Customer ";
            SqlDataAdapter sda = new SqlDataAdapter(qry2, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Customer");
            dataGridView1.DataSource = ds.Tables["Customer"];
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Transaction  f2 = new Transaction();
            f2.Show();
        }
    }
}
