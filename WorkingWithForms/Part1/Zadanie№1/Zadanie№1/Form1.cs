using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Считывание значения x
            double x = double.Parse(textBox1.Text);

            // Считывание значения y
            double y = double.Parse(textBox2.Text);

            // Считывание значения z
            double z = double.Parse(textBox3.Text);

            // Вычисляем арифметическое выражение
            double a = (Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3)) /
                (Math.Pow(x, 2) + Math.Pow(y, 2) + 2);
            double b = Math.Exp(x - y);
            double c = Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);
            double u = a - b * c;

            // Выводим результат в окно
            textBox4.Text += $"Результат u = {u}" + Environment.NewLine;
        }
    }
}
