using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = String.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Обновление формы
            textBox6.Text = String.Empty;

            //Считывание значения имени, фамилиии и отчества
            string surname = Convert.ToString(textBox1.Text);
            string name = Convert.ToString(textBox2.Text);
            string patronymic = Convert.ToString(textBox3.Text);

            //Считывание значения пола
            string sex1 = Convert.ToString(radioButton1.Text);
            string sex2 = Convert.ToString(radioButton2.Text);

            //Считывание значения даты рождения
            string day = Convert.ToString(comboBox1.Text);
            string month = Convert.ToString(comboBox2.Text);
            string year = Convert.ToString(comboBox3.Text);

            //Считывание значения места положения, адреса электронной почты, SIM-карты и номера телефона
            string city = Convert.ToString(comboBox4.Text);
            string address = Convert.ToString(textBox4.Text);
            string sim = Convert.ToString(comboBox5.Text);
            string telefon = Convert.ToString(textBox5.Text);

            //Считывание значения опыта работы
            string work1 = Convert.ToString(radioButton3.Text);
            string work2 = Convert.ToString(radioButton4.Text);
            string work3 = Convert.ToString(radioButton5.Text);
            string work4 = Convert.ToString(radioButton6.Text);
            string work5 = Convert.ToString(radioButton7.Text);

            //Считывание значения других сведений и категорий прав
            string other1 = Convert.ToString(checkBox1.Text);
            string other2 = Convert.ToString(checkBox2.Text);
            string A = Convert.ToString(checkBox3.Text);
            string B = Convert.ToString(checkBox4.Text);
            string C = Convert.ToString(checkBox5.Text);
            string D = Convert.ToString(checkBox6.Text);

            //Считывание значения минимального и максимального объёма заработной платы
            string min = Convert.ToString(numericUpDown1.Text);
            string max = Convert.ToString(numericUpDown2.Text);

            //Считывание значения предпочитаемого графика работы
            string schedule1 = Convert.ToString(radioButton8.Text);
            string schedule2 = Convert.ToString(radioButton9.Text);
            string schedule3 = Convert.ToString(radioButton10.Text);
            string schedule4 = Convert.ToString(radioButton11.Text);

            //Запись имени
            if (textBox1.Text == String.Empty)
                textBox6.Text += $"Имя: пусто" + Environment.NewLine;
            else
                textBox6.Text += $"Имя: {name}" + Environment.NewLine;

            //Запись фамилии
            if (textBox2.Text == String.Empty)
                textBox6.Text += $"Фамилия: пусто" + Environment.NewLine;
            else
                textBox6.Text += $"Фамилия: {surname}" + Environment.NewLine;

            //Запись отчества
            if (textBox3.Text == String.Empty)
                textBox6.Text += $"Отчество: пусто" + Environment.NewLine;
            else
                textBox6.Text += $"Отчество: {patronymic}" + Environment.NewLine;

            //Запись пола
            if (radioButton1.Checked)
                textBox6.Text += $"Пол: {sex1}" + Environment.NewLine + Environment.NewLine;
            else if (radioButton2.Checked)
                textBox6.Text += $"Пол: {sex2}" + Environment.NewLine + Environment.NewLine;
            else
                textBox6.Text += $"Пол: не был выбран" + Environment.NewLine + Environment.NewLine;

            //Запиь даты рождения
            textBox6.Text += $"Дата рождения: ";

            if (comboBox1.Text == String.Empty)
                textBox6.Text += $".../";
            else
                textBox6.Text += $"{day}/";

            if (comboBox2.Text == String.Empty)
                textBox6.Text += $".../";
            else
                textBox6.Text += $"{month}/";

            if (comboBox3.Text == String.Empty)
                textBox6.Text += $"..." + Environment.NewLine + Environment.NewLine;
            else
                textBox6.Text += $"{year}" + Environment.NewLine + Environment.NewLine;

            //Запись места проживания
            if (comboBox4.Text == String.Empty)
                textBox6.Text += $"Место проживания: не было выбрано" + Environment.NewLine;
            else
                textBox6.Text += $"Место проживания: {city}" + Environment.NewLine;

            //Запись адрес электронной почты
            if (textBox4.Text == String.Empty)
                textBox6.Text += $"Адрес электронной почты: пусто" + Environment.NewLine;
            else
                textBox6.Text += $"Адрес электронной почты: {address}" + Environment.NewLine;

            //Запись номера телефона
            if (comboBox5.Text == String.Empty)
                textBox6.Text += $"SIM-карта: не была выбрана" + Environment.NewLine;
            else
                textBox6.Text += $"SIM-карта: {sim}" + Environment.NewLine;

            if (textBox5.Text == String.Empty)
                textBox6.Text += $"Номер телефона: пусто" + Environment.NewLine + Environment.NewLine;
            else
                textBox6.Text += $"Номер телефона: {telefon}" + Environment.NewLine + Environment.NewLine;

            //Запись опыта работы
            if (radioButton3.Checked)
                textBox6.Text += $"Опыт работы: {work1}" + Environment.NewLine + Environment.NewLine;
            else if (radioButton4.Checked)
                textBox6.Text += $"Опыт работы: {work2}" + Environment.NewLine + Environment.NewLine;
            else if (radioButton5.Checked)
                textBox6.Text += $"Опыт работы: {work3}" + Environment.NewLine + Environment.NewLine;
            else if (radioButton6.Checked)
                textBox6.Text += $"Опыт работы: {work4}" + Environment.NewLine + Environment.NewLine;
            else if (radioButton7.Checked)
                textBox6.Text += $"Опыт работы: {work5}" + Environment.NewLine + Environment.NewLine;
            else
                textBox6.Text += $"Опыт работы: не был выбран" + Environment.NewLine + Environment.NewLine;

            //Запись других сведений
            if (checkBox1.Checked)
                textBox6.Text += $"Другиe сведения: {work1}" + Environment.NewLine;
            else if (checkBox2.Checked)
                textBox6.Text += $"Другиe сведенияы: {work2}" + Environment.NewLine;
            else
                textBox6.Text += $"Другиe сведения: не были выбраны" + Environment.NewLine;

            //Запись категорий прав
            if (checkBox3.Checked)
                textBox6.Text += $"    Категория прав: {A}" + Environment.NewLine + Environment.NewLine;
            else if (checkBox4.Checked)
                textBox6.Text += $"    Категория прав: {B}" + Environment.NewLine + Environment.NewLine;
            else if (checkBox4.Checked)
                textBox6.Text += $"    Категория прав: {C}" + Environment.NewLine + Environment.NewLine;
            else if (checkBox4.Checked)
                textBox6.Text += $"    Категория прав: {D}" + Environment.NewLine + Environment.NewLine;
            else
                textBox6.Text += $"    Категория прав: не была выбрана" + Environment.NewLine + Environment.NewLine;

            //Запись объёма заработной платы
            if (max == "")
                textBox6.Text += $"Объём заработной платы: От {min}" + Environment.NewLine +
                    Environment.NewLine;
            else if (numericUpDown1.Value > numericUpDown2.Value)
                textBox6.Text += $"Объём заработной платы превышает минимальный " + Environment.NewLine +
                    Environment.NewLine;
            else
                textBox6.Text += $"Объём заработной платы: От {min}  до {max}" + Environment.NewLine +
                    Environment.NewLine;

            //Запись предпочитаемого графика работы
            if (radioButton8.Checked)
                textBox6.Text += $"Предпочитаемый график работы: {schedule1}" + Environment.NewLine +
                    Environment.NewLine;
            else if (radioButton9.Checked)
                textBox6.Text += $"Предпочитаемый график работы: {schedule2}" + Environment.NewLine +
                    Environment.NewLine;
            else if (radioButton10.Checked)
                textBox6.Text += $"Предпочитаемый график работы: {schedule1}" + Environment.NewLine +
                    Environment.NewLine;
            else if (radioButton11.Checked)
                textBox6.Text += $"Предпочитаемый график работы: {schedule4}" + Environment.NewLine +
                    Environment.NewLine;
            else
                textBox6.Text += $"Предпочитаемый график работы: не был выбран" + Environment.NewLine +
                    Environment.NewLine;
        }
    }
}