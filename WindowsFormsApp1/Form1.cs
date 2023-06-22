using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : Form
    {
        DataBase dataBase = new DataBase();
        public Products()
        {
            InitializeComponent();
        }

        private void пустышка_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.register". При необходимости она может быть перемещена или удалена.
            this.registerTableAdapter.Fill(this.testDataSet.register);

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var pass = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into register(login_user, password_user) values ('{login}', '{pass}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
               

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            dataBase.CloseConnection();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tovar frm_Tovar = new Tovar();
            frm_Tovar.Show();
            
        }
    }
}
