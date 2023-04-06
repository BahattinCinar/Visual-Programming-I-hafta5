using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, a, b, c, sum = 0;

            /*
            for (i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
            */
                        
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Girmediginiz deger bulunuyor lutfen giriniz!!!");
            }

            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);

                if (b > a)
                {
                    for (i = a; i <= b; i += c)
                    {
                        sum = sum + i;
                        listBox1.Items.Add(i);
                    }

                    textBox4.Text = sum.ToString();
                }

                else
                {
                    for (i = b; i <= a; i += c)
                    {
                        sum = sum + i;
                        listBox1.Items.Add(i);
                    }

                    textBox4.Text = sum.ToString();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("deneme");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
