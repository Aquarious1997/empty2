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


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=");
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try{
                con.Open();
                string productname = comboBox4.SelectedItem.ToString();
                string itemtype = comboBox2.SelectedItem.ToString();
                string from = comboBox1.SelectedItem.ToString();
                string to = comboBox3.SelectedItem.ToString();
                string itemprice = textBox1.Text.ToString();
                int iitemprice = Int32.Parse(itemprice);
                string itemquantity = textBox3.Text.ToString();
                int iitemquantity = Int32.Parse(itemquantity);
                string capcity = textBox4.Text.ToString();
                int icapcity = Int32.Parse(capcity);

                MessageBox.Show("your data has been submitted");
           // }
            //catch
          //  {

           //}
        }
    }
}
