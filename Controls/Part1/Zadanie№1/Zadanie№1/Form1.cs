using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            List<string> wordsList = new List<string>();
            foreach (string item in listBox1.Items)
            {
                wordsList.Add(item);
            }

            string text = string.Join(" ", wordsList);

            // Подсчёт количество слов в тексте
            int wordCount = text.Split().Length;

            label1.Text = $"Количество слов: {wordCount}";
        }
    }
}