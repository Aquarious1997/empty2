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
                if (i.Email == textBox1.Text && i.Password == textBox2.Text)
                {
                    MessageBox.Show("You are in ");
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                }
                else
                {
                    MessageBox.Show("Incorrect email/Password");
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                }
            }
        }

    }
}
