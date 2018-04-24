using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalidresult;
            bool isvalidpassed;
            localhost.Service1 d = new localhost.Service1();
            d.isvalid(textBox1.Text, textBox2.Text, out isvalidresult, out isvalidpassed);

            if (isvalidresult)
            {
                MessageBox.Show("Valid user");
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
