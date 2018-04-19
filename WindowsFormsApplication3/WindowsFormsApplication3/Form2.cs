using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Class2 i in Class1.db)
            {
                if(i.Name==textBox1.Text && i.Password == textBox2.Text)
                {
                    MessageBox.Show("Successfyully Login");
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                }
                else
                {
                    MessageBox.Show("Sorry Wrong Information");
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                }
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
