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
        //struct User
        //{
        //    public string login;
        //    public string password;
        //}
        public static string local_user_path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginDataCheck(loginBox.Text, passwordBox.Text))
            {
                FindDirectoryAndFile(loginBox.Text + "/Data.csv");
                MainMenu mainMenu = new MainMenu();
                Hide();
                mainMenu.Show();
            }
        }

        private bool LoginDataCheck(string login, string password)
        {
            List<Users> userList = new List<Users>();
            try
            {
                using (StreamReader sr = new StreamReader("userData.csv", Encoding.UTF8, true))
                {
                    while (sr.EndOfStream != true)
                    {
                        string[] str = sr.ReadLine().Split(';');
                        userList.Add(new Users() { login = str[0], pass = str[1], score = Convert.ToInt32(str[2]) });
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка считывания данных!");
            }
            foreach (Users user in userList)
            {
                if (user.login == login && user.pass == Hashing.Hash(password))
                {
                    return true;
                }
            }
            MessageBox.Show("Данные неверны!");
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (RegisterDataCheck(loginBox.Text, passwordBox.Text))
            {
                RegisterSaveData(loginBox.Text, passwordBox.Text);
            }
        }

        private bool RegisterDataCheck(string login, string password)
        {
            List<Users> userList = new List<Users>();
            try
            {
                using (StreamReader sr = new StreamReader("userData.csv", Encoding.UTF8, true))
                {
                    while (sr.EndOfStream != true)
                    {
                        string[] str = sr.ReadLine().Split(';');
                        userList.Add(new Users() { login = str[0], pass = str[1], score = Convert.ToInt32(str[2]) });
                    }
                }
                foreach (Users user in userList)
                {
                    if (user.login == login)
                    {
                        MessageBox.Show("Такой логин уже используется!");
                        return false;
                    }
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка считывания данных!");
                return false;
            }            
        }
        private void RegisterSaveData(string login, string password)
        {
            List<Users> userList = new List<Users>();
            try
            {
                using (StreamWriter sw = new StreamWriter("userData.csv", true))
                {
                    sw.WriteLine(login + ";" + Hashing.Hash(password) + ";0;");
                }
                //local_user_path = login + "Data.csv";                
                MessageBox.Show("Успешная регистрация!");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения данных.");
            }
        }
        private void FindDirectoryAndFile(string path)
        {
            if(File.Exists(path))
            {
                local_user_path = path;
            }
            else
            {
                Directory.CreateDirectory(loginBox.Text);
                File.Create(path);
            }
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
