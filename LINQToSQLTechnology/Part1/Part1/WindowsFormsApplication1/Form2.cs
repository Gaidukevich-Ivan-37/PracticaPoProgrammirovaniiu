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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=turfirm.mdb;";

        private OleDbConnection myConnection;

        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "Select * from Туры";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void турыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from Туры";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Туры");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from Туристы";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Туристы");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void сезоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from Сезоны";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Сезоны");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from Путевки";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Путевки");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from Оплата";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Оплата");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void информацияОТуристахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            dataGridView1.DataSource = null;
            string query = "Select * from ИнформацияОТуристах";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "ИнформацияОТуристах");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
