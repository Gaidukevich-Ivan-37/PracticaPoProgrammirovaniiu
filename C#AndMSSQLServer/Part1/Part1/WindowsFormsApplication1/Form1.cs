using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=turfirm.mdb;";

        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select * from Туры";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            string query2 = "Select * from Туристы";
            OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter(query2, myConnection);
            DataSet ds2 = new DataSet();
            dataAdapter2.Fill(ds2, "Туристы");
            dataGridView2.DataSource = ds2.Tables[0].DefaultView;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

                myConnection.Open();
                string query = "DELETE FROM Туры where Код=" + id;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                dataGridView1.DataSource = null;
                string q = "Select * from Туры";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Туры");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            else
                MessageBox.Show("Выберите строку для удаления!", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surName = textBox2.Text;
            string otche = textBox3.Text; 


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Поля ввода пусты!", "Ошибка");
            }
            else
            {
                myConnection.Open();
                string query = "INSERT INTO Туристы (Имя, Фамилия, Отчество) VALUES ('" + name + "', '" + surName + "', '" + otche + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                dataGridView2.DataSource = null;
                string q = "Select * from Туристы";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Туристы");
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surName = textBox2.Text;
            string otche = textBox3.Text; 

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Поля ввода пусты!", "Ошибка");
            }
            else
            {
                if (dataGridView2.SelectedRows.Count != 0)
                {
                    myConnection.Open();
                    var id = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();
                    string query = "UPDATE Туристы SET Имя='" + name + "', Фамилия='" + surName + "' , Отчество='" + otche + "' where Код=" + id;
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    myConnection.Close();
                    dataGridView2.DataSource = null;
                    string q = "Select * from Туристы";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, "Туристы");
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                var id = dataGridView2[0, dataGridView2.CurrentRow.Index].Value.ToString();

                myConnection.Open();
                string query = "DELETE FROM Туристы where Код=" + id;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                dataGridView2.DataSource = null;
                string q = "Select * from Туристы";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Туристы");
                dataGridView2.DataSource = ds.Tables[0].DefaultView;

            }
            else
                MessageBox.Show("Выберите строку для удаления!", "Ошибка");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            int zena = int.Parse(textBox5.Text);
            string info = textBox6.Text;


            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Поля ввода пусты!", "Ошибка");
            }
            else
            {
                myConnection.Open();
                string query = "INSERT INTO Туры (Название, Цена, Информация) VALUES ('" + name + "', '" + zena + "', '" + info + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
                dataGridView1.DataSource = null;
                string q = "Select * from Туры";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Туры");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox4.Text;
                int zena = int.Parse(textBox5.Text);
                string info = textBox6.Text;

                if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Поля ввода пусты!", "Ошибка");
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        myConnection.Open();
                        var id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                        string query = "UPDATE Туры SET Название='" + name + "', Цена='" + zena + "' , Информация='" + info + "' where Код=" + id;
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        command.ExecuteNonQuery();
                        myConnection.Close();
                        dataGridView1.DataSource = null;
                        string q = "Select * from Туры";
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, myConnection);
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, "Туры");
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ошибка, проверьте введенные данные!", "Ошибка");
            }
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
