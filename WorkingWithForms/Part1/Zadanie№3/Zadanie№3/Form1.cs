using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X(0)
            textBox1.Text = "-0,75";

            // Начальное значение X(k)
            textBox2.Text = "-1,5";

            // Начальное значение Dx
            textBox3.Text = "-0,05";

            // Начальное значение A
            textBox4.Text = "1,5";

            // Начальное значение B
            textBox5.Text = "1,2";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);

            // Цикл для табулирования функции
            double x = x0;
            while (xk <= x)
            {
                double y = 1.2 * Math.Pow(a - b, 3) * Math.Exp(Math.Pow(x, 2)) + x;
                textBox6.Text += $"f({x})={y}"+Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
