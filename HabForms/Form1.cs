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
using System.Security.Cryptography;

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
            if (CheckUserData(loginBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Yay!");
            }
            else
            {
                MessageBox.Show("Данные неверны!");
            }
        }

        private bool CheckUserData(string login, string password)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
