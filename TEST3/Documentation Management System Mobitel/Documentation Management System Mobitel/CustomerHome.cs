using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documentation_Management_System_Mobitel
{
    public partial class CustomerHome : Form
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            VAS f1 = new VAS();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ServiceDetail f1 = new ServiceDetail();
            f1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            Transaction f1 = new Transaction();
            f1.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }
    }
}
