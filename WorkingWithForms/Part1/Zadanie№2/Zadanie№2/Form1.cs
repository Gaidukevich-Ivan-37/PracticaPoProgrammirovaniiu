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

namespace Zadanie_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            // Вычисление выражения
            double c = 0;
            if (x - y == 0)
                c = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Sin(y);
            if (x - y > 0)
                c = Math.Pow(x - y, 2) + Math.Cos(y);
            else
                c = Math.Pow(y - x, 2) + Math.Tan(y);

            // Вывод результата
            textBox4.Text += $"Результат c = {c}" + Environment.NewLine;
        }
    }
}
