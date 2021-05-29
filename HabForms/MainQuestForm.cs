using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace HabForms
{
    public partial class MainQuestForm : Form
    {
        List<Page> pages = new List<Page>();
        List<Save> saves = new List<Save>();
        Page curPage = new Page();
        string Path;
        string QuestName;
        public MainQuestForm(string Path, string QuestName)
        {
            this.Path = Path;
            this.QuestName = QuestName;
            InitializeComponent();
            FormClosing += MainQuestForm_OnClosing;
            ReadingPage();
            UpdatePage("1");
        }
        private void ReadingPage()
        {
            string tempID = "", tempImageLink = "", tempMainText = "", tempFVar = "", tempSVar = "", tempTVar = "", tempFLink = "", tempSLink = "", tempTLink = "";
            var lines = File.ReadAllLines(Path);            
            Regex text = new Regex("(?<=\\$[1-3]).*(?=\\&.*)");
            Regex linkr = new Regex("(?<=\\&).*");
            foreach (var line in lines)
            {
                if (line == "@/")
                {
                    if (tempFLink == null || tempFLink == "") tempFLink = tempID;
                    if (tempSLink == null || tempSLink == "") tempSLink = tempID;
                    if (tempTLink == null || tempTLink == "") tempTLink = tempID;
                    pages.Add(new Page { pageID = tempID, imageLink = tempImageLink, mainText = tempMainText, fVar = tempFVar, sVar = tempSVar, tVar = tempTVar, fLink = tempFLink, sLink = tempSLink, tLink = tempTLink });
                    tempID = "";
                    tempImageLink = "";
                    tempMainText = "";
                    tempFVar = "";
                    tempSVar = "";
                    tempTVar = "";
                    tempFLink = "";
                    tempSLink = "";
                    tempTLink = "";
                }
                else if (line.StartsWith("@")) tempID = line.Replace("@", string.Empty);
                else if (line.StartsWith("!")) tempImageLink = line.Replace("!", string.Empty);
                else if (line.StartsWith("#")) tempMainText = line.Replace("#", string.Empty);
                else if (line.StartsWith("$1"))
                {
                    tempFVar = text.Match(line).ToString();
                    tempFLink = linkr.Match(line).ToString();
                }
                else if (line.StartsWith("$2"))
                {
                    tempSVar = text.Match(line).ToString();
                    tempSLink = linkr.Match(line).ToString();
                }
                else if (line.StartsWith("$3"))
                {
                    tempTVar = text.Match(line).ToString();
                    tempTLink = linkr.Match(line).ToString();
                }
            }
        }
        private void UpdatePage(string link)
        {
            var tempPage = pages.Find(x => x.pageID == link);
            UpdatePageData(tempPage);
            mainTextLable.Text = tempPage.mainText;
            try
            {
                pictureBox1.Image = Image.FromFile(tempPage.imageLink);
            }
            catch
            {
                pictureBox1.Image = null;
            }
            answerButton1.Text = tempPage.fVar;
            if (tempPage.fVar != "")
            {
                answerButton1.Show();
                answerButton1.Text = tempPage.fVar;

            }
            else
            {
                answerButton1.Hide();
            }
            if (tempPage.sVar != "")
            {
                answerButton2.Show();
                answerButton2.Text = tempPage.sVar;
                
            }
            else
            {
                 answerButton2.Hide();
            }
            if (tempPage.tVar != "")
            {
                answerButton3.Show();
                answerButton3.Text = tempPage.tVar;
                
            }
            else
            {
                answerButton3.Hide();
            }
        }
        void Save()
        {
            string path = Form1.local_user_path + "/Saves.csv";
            if(File.Exists(path))
            {
                int i = 0;
                var lines = File.ReadAllLines(path).ToList();
                bool saveIsFound = false;
                while(i < lines.Count)
                {
                    if (lines[i].StartsWith(QuestName)) 
                    {
                        lines[i] = QuestName + ";" + curPage.pageID;
                        saveIsFound = true;
                        break;
                    }
                    i++;
                }
                if(!saveIsFound)
                {
                    lines.Add(QuestName + ";" + curPage.pageID);
                }
                File.WriteAllLines(path, lines);
            }
            else
            {
                File.Create(path).Close();
                if (Settings.autosaveIsOn) Save();
            }
        }

        void LoadGame()
        {
            string path = Form1.local_user_path + "/Saves.csv";
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path).ToList();
                foreach (var line in lines)
                {
                    if (line.StartsWith(QuestName))
                    {
                        UpdatePage(line.Split(';')[1]);
                    }
                }
            }
            else
            {
                File.Create(path).Close();
                if (Settings.autosaveIsOn) Save();
            }
        }

        private void UpdatePageData(Page newPage)
        {
            curPage = newPage;
        }

        private void answerButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Settings.autosaveIsOn);
            if (Settings.autosaveIsOn.ToString() == "True") Save();
            UpdatePage(curPage.fLink);            
        }

        private void answerButton2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Settings.autosaveIsOn.ToString());
            if (Settings.autosaveIsOn.ToString() == "True") Save();
            UpdatePage(curPage.sLink);            
        }

        private void answerButton3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Settings.autosaveIsOn);
            if (Settings.autosaveIsOn.ToString() == "True") Save();
            UpdatePage(curPage.tLink);            
        }

        private void mainTextLable_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainQuestForm_OnClosing(object sender, EventArgs e)
        {
            if (Settings.autosaveIsOn) Save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите начать новую игру?",
            "Новая игра",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if(result == DialogResult.Yes)
            {
                UpdatePage("1");
                Save();
            }
        }
    }
}
