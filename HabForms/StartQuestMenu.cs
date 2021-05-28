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
            Regex withoutTXT = new Regex("(?<=\\/Quests\\/).*(?=\\.txt)");
            string[] filesq = Directory.GetFiles(@"../../Quests/");
            foreach (var file in filesq)
            {
                listBox1.Items.Add(withoutTXT.Match(file).ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string questName = listBox1.SelectedItem.ToString();
                string path = @"../../Quests/" + questName + ".txt";
                MainQuestForm m = new MainQuestForm(path, questName);
                m.ShowDialog();
            }
        }
    }
}
