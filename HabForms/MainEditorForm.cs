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
using System.Diagnostics;

namespace HabForms
{
    public partial class MainEditorForm : Form
    {
        int curPage = 0;
        string Path;
        List<Page> pages = new List<Page>();
        public MainEditorForm(string Path)
        {
            this.Path = Path;
            InitializeComponent();
            FormClear();
        }

        private void exitEditor_Click(object sender, EventArgs e)
        {

        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            NextPage();
            WriteQuestToFile();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            LastPage();
            WriteQuestToFile();
        }

        private void AddPage(int pageCount)
        {
            pages.Add(new Page
            {
                pageID = Convert.ToString(pageCount),
                imageLink = pictureBoxEditor.ImageLocation,
                mainText = mainTextED.Text,
                fLink = firstLinkList.Text,
                fVar = edFirstVar.Text,
                sLink = secondLinkList.Text,
                sVar = edSecondVar.Text,
                tLink = thirdLinkList.Text,
                tVar = edThirdVar.Text
            });
        }

        private void NextPage()
        {
            if(curPage == pages.Count)
            {
                AddPage(pages.Count + 1);
                curPage += 1;
                FormClear();
            }
            else
            {
                curPage += 1;
                pageNumber.Text = UpdateID();
                //pages.Count.ToString();
                //Convert.ToString(curPage);
                pictureBoxEditor.ImageLocation = pages[curPage - 1].imageLink;
                mainTextED.Text = pages[curPage - 1].mainText;
                firstLinkList.Text = pages[curPage - 1].fLink;
                edFirstVar.Text = pages[curPage - 1].fVar;
                secondLinkList.Text = pages[curPage - 1].sLink;
                edSecondVar.Text = pages[curPage - 1].sVar;
                thirdLinkList.Text = pages[curPage - 1].tLink;
                edThirdVar.Text = pages[curPage - 1].tVar;
            }
        }

        private void LastPage()
        {
            if (curPage != 0)
            {
                curPage -= 1;
                pageNumber.Text = UpdateID();
                //pages.Count.ToString();
                //Convert.ToString(curPage);
                pictureBoxEditor.ImageLocation = pages[curPage].imageLink;
                mainTextED.Text = pages[curPage].mainText;
                firstLinkList.Text = pages[curPage].fLink;
                edFirstVar.Text = pages[curPage].fVar;
                secondLinkList.Text = pages[curPage].sLink;
                edSecondVar.Text = pages[curPage].sVar;
                thirdLinkList.Text = pages[curPage].tLink;
                edThirdVar.Text = pages[curPage].tVar;
            }
        }

        private void FormClear()
        {
            pageNumber.Text = UpdateID();
            pictureBoxEditor.Image = null;
            mainTextED.Clear();
            firstLinkList.Text = null;
            edFirstVar.Clear();
            secondLinkList.Text = null;
            edSecondVar.Clear();
            thirdLinkList.Text = null;
            edThirdVar.Clear();
        }

        private void addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pictureBoxEditor.ImageLocation = fileDialog.FileName;
        }
        private void WriteQuestToFile()
        {
            File.WriteAllText(Path, null);
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                foreach (Page page in pages)
                {
                    sw.WriteLine("@" + page.pageID);
                    if(page.imageLink != null && page.imageLink != "") sw.WriteLine("!" + page.imageLink);
                    sw.WriteLine("#" + page.mainText);
                    sw.WriteLine("$1" + page.fVar + "&" + page.fLink);
                    if(page.sVar != null) sw.WriteLine("$2" + page.sVar + "&" + page.sLink);
                    if (page.tVar != null) sw.WriteLine("$3" + page.tVar + "&" + page.tLink);
                    sw.WriteLine("@/");
                    sw.WriteLine("\n");
                }                
            }
            
        }
        private string UpdateID()
        {
            string ID = (curPage+1)+"/"+(pages.Count+1);
            
            return ID;
        }
        private void DeletePage()
        {
            if (curPage != 0 && curPage < pages.Count)
            {
                pages.RemoveAt(curPage);
                FormClear();
                LastPage();
            }
            else if(curPage == pages.Count)
            {
                FormClear();
                LastPage();
            }
        }
        private void mainTextED_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletePage_Click(object sender, EventArgs e)
        {
            DeletePage();
        }
    }
}
