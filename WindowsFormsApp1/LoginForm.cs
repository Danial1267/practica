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
    public partial class LoginForm : Form
    {

        DataBase dataBase = new DataBase();
        public LoginForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 46);
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
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}' ";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Products frm1 = new Products();
                this.Hide();
                frm1.Show();


            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm frm_sign = new RegForm();
            frm_sign.Show();
            this.Hide();
        }
    }
}
