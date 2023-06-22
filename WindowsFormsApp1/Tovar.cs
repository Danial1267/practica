using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class Tovar : Form
    {
        DataBase dataBase = new DataBase();
        public Tovar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.testDataSet1.tovar);

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var count = textBox2.Text;
            var postavshik = textBox3.Text;
            var otdelen = textBox4.Text;
            var price = textBox5.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into tovar(name_tovar, count, postavshik, otdelen, price) values ('{name}', '{count}','{postavshik}', '{otdelen}', '{price}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар добавлен!");


            }
            else
            {
                MessageBox.Show("Товар не добавлен!");
            }

            dataBase.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name1 = textBox6.Text;

            string querystring = $"DELETE tovar Where name_tovar = '{name1}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар удален!");


            }
            else
            {
                MessageBox.Show("Товар не удален!");
            }

            dataBase.CloseConnection();
        }
    }
}
