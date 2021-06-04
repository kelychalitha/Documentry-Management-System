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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Sidepanel.Height = button6.Height;
            Sidepanel.Top=button6.Top;
            home1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            userControl11.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Payment f1 = new Payment();
            f1.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Contact f1 = new Contact();
            f1.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VAS f1 = new VAS();
            f1.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Admin f1 = new Admin();
            f1.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button6.Height;
            Sidepanel.Top = button6.Top;
            home1.BringToFront();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
