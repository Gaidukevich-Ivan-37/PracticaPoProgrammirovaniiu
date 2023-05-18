using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            Control newControl = null;
            switch (input)
            {
                case "К":
                    newControl = new Button();
                    newControl.Text = "Кнопка";
                    break;
                case "П":
                    newControl = new TextBox();
                    newControl.Text = "Поле ввода";
                    break;
                case "М":
                    newControl = new Label();
                    newControl.Text = "Метка";
                    break;
                default:
                    MessageBox.Show("Неверный ввод");
                    break;
            }

            if (newControl != null)
            {
                newControl.Location = new Point(x, y);
                newControl.BackColor = Color.White;
                newControl.ForeColor = Color.Black;
                newControl.Size = new Size(100, 30);
                newControl.MouseHover += (s, ev) =>
                {
                    this.Controls.Remove(newControl);
                };

                this.Controls.Add(newControl);
            }
        }
    }
}