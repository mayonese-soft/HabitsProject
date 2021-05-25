using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabForms
{
    public partial class Form1 : Form
    {
        struct User
        {
            public string login;
            public string password;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginDataCheck(loginBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Yay!");
            }
            else
            {
                MessageBox.Show("Данные неверны!");
            }
        }

        private bool LoginDataCheck(string login, string password)
        {
            List<User> userList = new List<User>();
            try
            {
                using (StreamReader sr = new StreamReader("userData.csv"))
                {
                    while (sr.EndOfStream != true)
                    {
                        string[] str = sr.ReadLine().Split(';');
                        userList.Add(new User() { login = str[0], password = str[1] });
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка считывания данных!");
            }
            foreach (User user in userList)
            {
                if (user.login == login && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (RegisterDataCheck(loginBox.Text, passwordBox.Text))
            {
                RegisterSaveData(loginBox.Text, passwordBox.Text);
            }
            else
            {
                MessageBox.Show("Такой логин уже используется!");
            }
        }

        private bool RegisterDataCheck(string login, string password)
        {
            List<User> userList = new List<User>();
            try
            {
                using (StreamReader sr = new StreamReader("userData.csv"))
                {
                    while (sr.EndOfStream != true)
                    {
                        string[] str = sr.ReadLine().Split(';');
                        userList.Add(new User() { login = str[0], password = str[1] });
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка считывания данных!");
            }
            foreach (User user in userList)
            {
                if (user.login == login)
                {
                    return false;
                }
            }
            return true;
        }

        private void RegisterSaveData(string login, string password)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("userData.csv"))
                {
                    sw.WriteLine(login + ";" + password + ";");
                }
                MessageBox.Show("Успешная регистрация!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения данных.");
            }
        }
    }
}
