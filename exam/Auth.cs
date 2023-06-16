using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Auth : Form
    {
        private DBHelper dbh;
        public Auth()
        {
            InitializeComponent();
            dbh = new DBHelper("localhost", 3306, "root", "", "exam");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (login.Length == 0 || password.Length == 0) 
            {
                MessageBox.Show(
                "Введите логин и пароль!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (dbh.LogIn(login, password)) {
                MessageBox.Show(
                "Вы успешно залогинились!",
                "Авторизация прошла успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                Form1 form = new Form1(login, password);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show(
                "Неизвестный логин или пароль!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox4.Text;
            string password = textBox3.Text;
            if (dbh.CheckLogin(login))
            {
                MessageBox.Show(
                "Этот логин уже занят!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (login.Length < 5 || password.Length < 5)
            {
                MessageBox.Show(
                "Длина логина или пароля не может быть меньше 5 символов!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                dbh.RegiterNewUser(login, password);
                MessageBox.Show(
                "Вы успешно зарегестрировались!",
                "Регистрация прошла успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                Form1 form = new Form1(login, password);
                this.Hide();
                form.Show();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
