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

namespace HabForms
{
    public partial class MainQuestForm : Form
    {
        List<Page> pages = new List<Page>();
        Page curPage = new Page();
        
        public MainQuestForm()
        {
            InitializeComponent();
            ReadingPage();
            UpdatePage("1");
        }
        private void ReadingPage()
        {
            string tempID = "", tempMainText = "", tempFVar = "", tempSVar = "", tempTVar = "", tempFLink = "", tempSLink = "", tempTLink = "";
            var lines = File.ReadAllLines("qst1.txt");            
            Regex text = new Regex("/(?<=\\$[1-3]).*(?=\\&.*)");
            Regex linkr = new Regex("/(?<=\\&).*");
            foreach (var line in lines)
            {
                if (line == "@/")
                {
                    pages.Add(new Page { pageID = tempID, mainText = tempMainText, fVar = tempFVar, sVar = tempSVar, tVar = tempTVar, fLink = tempFLink, sLink = tempSLink, tLink = tempTLink });
                    tempID = "";
                    tempMainText = "";
                    tempFVar = "";
                    tempSVar = "";
                    tempTVar = "";
                    tempFLink = "";
                    tempSLink = "";
                    tempTLink = "";
                }
                else if (line.StartsWith("@")) 
                {                    
                    tempID = line.Replace("@",string.Empty);
                } 
                else if (line.StartsWith("#")) tempMainText = line;
                else if (line.StartsWith("$1"))
                {
                    tempFVar = text.Match(line).ToString();
                    tempFLink = linkr.Match(line).ToString();
                    //mainTextLable.Text = tempAnswers.GetKey(0).ToString() + tempAnswers.GetByIndex(0).ToString();
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
            answerButton1.Text = tempPage.fVar;
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
            
            //answerButton1.Text = tempPage.answers.GetKey(0).ToString();
            //answerButton2.Text = tempPage.answers.GetKey(1).ToString();
            //answerButton3.Text = tempPage.answers.GetKey(2).ToString();
        }

        private void UpdatePageData(Page newPage)
        {
            curPage = newPage;
        }

        private void answerButton1_Click(object sender, EventArgs e)
        {
            UpdatePage(curPage.fLink);
        }

        private void answerButton2_Click(object sender, EventArgs e)
        {
            UpdatePage(curPage.sLink);
        }

        private void answerButton3_Click(object sender, EventArgs e)
        {
            UpdatePage(curPage.tLink);
        }
    }
    

    
}
