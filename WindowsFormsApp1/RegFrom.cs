using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        DataBase dataBase = new DataBase();
        public RegForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Coral;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Coral; closeButton.ForeColor = Color.Red;
        }
        Point lastpoint;
        private void RegForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void RegForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = loginField.Text;
            var password = passField.Text;
            string querystring = $"insert into register(login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            dataBase.CloseConnection();

        }

        private Boolean checkuser()
        {
            var loginUser = loginField.Text;
            var passwordUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();  
            DataTable table = new DataTable();
            string querystring = $"selesct id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand= command;
            adapter.Fill(table);
            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;

            }
            else
            {
                return false;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frm_sign = new LoginForm();
            frm_sign.Show();
            this.Hide();
        }
    }
}

           