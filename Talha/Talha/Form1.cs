using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 usr = new Class2();
            usr.Name = textBox1.Text;
            usr.Email = textBox2.Text;
            usr.Password = textBox3.Text;


            Class1.db.Add(usr);


            MessageBox.Show("SignUP Success");

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
