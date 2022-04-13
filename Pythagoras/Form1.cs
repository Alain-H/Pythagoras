using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pythagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0;
                double b = 0;
                double c = 0;
                if (textBox1.Text != "0" && textBox2.Text != "0" && textBox3.Text == "")
                {
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    textBox3.Text = Math.Sqrt(a * a + b * b).ToString();
                }
                else if (textBox1.Text != "0" && textBox2.Text == "" && textBox3.Text != "0") 
                {
                    a = Convert.ToDouble(textBox1.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    if(c < a)
                    {
                        MessageBox.Show("Die Hypothenuse kann nicht kleiner als eine Kathete sein!");
                    }
                    else
                    textBox2.Text = Math.Sqrt(c * c - a * a).ToString();
                }
                else if(textBox1.Text == "" && textBox2.Text != "0" && textBox3.Text != "0")
                {
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    if (c < b)
                    {
                        MessageBox.Show("Die Hypothenuse kann nicht kleiner als eine Kathete sein!");
                    }
                    else
                    textBox1.Text = Math.Sqrt(c * c - b * b).ToString();
                }
                else if(textBox1.Text == "0" || textBox2.Text == "0" || textBox3.Text == "0")
                {
                    MessageBox.Show("Leider akzeptiert Pythagoras keine 0 ");
                }
                else if(textBox1.Text==""&& textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Formfehler!");
                }
                


            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message, "Fehler!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
