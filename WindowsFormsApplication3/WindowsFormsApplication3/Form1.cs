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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 usr = new Class2();
            usr.Email = textBox3.Text;
            usr.Name = textBox1.Text;
            usr.Password = textBox2.Text;
            
           
            Class1.db.Add(usr);


            MessageBox.Show("successfuly Register");

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";






        }
    }
}
