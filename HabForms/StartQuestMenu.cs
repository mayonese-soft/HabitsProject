using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabForms
{
    public partial class StartQuestMenu : Form
    {
        public StartQuestMenu()
        {
            InitializeComponent();
            FormClosing += StartQuestMenu_OnClosing;
            LoadQuests();
        }

        private void LoadQuests()
        {            
            Regex withoutPath = new Regex("(?<=.\\/).*");
            //string[] filesq = Directory.GetFiles(@"../../Quests/");
            //foreach (var file in filesq)
            //{
            //    listBox1.Items.Add(withoutTXT.Match(file).ToString());
            //}
            //listBox1.Items.AddRange(Directory.GetDirectories(@"Quests/"));
            string[] filesq = Directory.GetDirectories(@"Quests/");
            foreach (var file in filesq)
            {
                listBox1.Items.Add(withoutPath.Match(file).ToString());
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.instance.Show();
        }

        private void StartQuestMenu_OnClosing(object sender, EventArgs e)
        {
            MainMenu.instance.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string FindQuestTXTFile(string questDirName)
        {
            //Regex withoutTXT = new Regex("(?<=.\\/).*(?=\\.)");
            Regex withoutTXT = new Regex("[^\\/]+(?=\\.txt$)");
            string[] allQuestFiles = Directory.GetFiles(@"Quests/" + questDirName + "/");
            foreach (var file in allQuestFiles)
            {
                if (file.Contains(".txt")) return withoutTXT.Match(file).ToString();                
            }
            return "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string questDirName = listBox1.SelectedItem.ToString();
                string questName = FindQuestTXTFile(questDirName);
                if (questName != "")
                {
                    string path = @"Quests/" + questDirName + "/" + questName + ".txt";
                    MainQuestForm m = new MainQuestForm(path, questName);
                    m.ShowDialog();
                }
                else MessageBox.Show("К сожалению, тут нет квеста...");
            }
        }
    }
}
