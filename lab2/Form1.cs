using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "182,5";
            textBox2.Text= "18,225";
            textBox3.Text="-0,03298";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + 
                "X= " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
                "Y= " +y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
                "Z= " + z.ToString();
            double a = Math.Abs(Math.Pow(x, (y / x)) - Math.Pow((y / x), 1 / 3));
            double b = (y - x);
            double c = Math.Cos(y) - (z / (y - x));
            double d = 1 + Math.Pow((y - x), 2);
            double u = a + b * (c / d);
            textBox4.Text += Environment.NewLine +
                "Результат U= " + u.ToString();
                


        }
    }
}
