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
    public partial class VAS : Form
    {
        public VAS()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TNT f1 = new TNT();
            f1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Music f1 = new Music();
            f1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Health f1 = new Health();
            f1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TNT f1 = new TNT();
            f1.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TNT f1 = new TNT();
            f1.Show();
        }
    }
}
