using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Farenheit to Celcius")
            {
                double f = double.Parse(textBox2.Text);
                double c;
                c = ( f- 32 ) * 5/9;

                textBox3.Text = c.ToString();
            }
            else if(comboBox1.Text == "Celcius to Farenheit")
            {
                double c = double.Parse(textBox2.Text);
                double f;
                f = (c * 9 / 5) + 32;

                textBox3.Text = f.ToString();
            }
            else
            {
                textBox3.Text = "Please Fill Above All The Details !!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
