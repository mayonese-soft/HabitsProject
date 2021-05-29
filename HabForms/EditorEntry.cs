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
    public partial class EditorEntry : Form
    {
        public EditorEntry()
        {
            InitializeComponent();
            LoadQuestList();
        }

        private void EditorEntry_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.instance.Show();
        }

        private void questList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadQuestList()
        {
            Regex withoutPath = new Regex("[^\\/]+(?=\\.txt$)");
            string[] filesq = Directory.GetFiles(@"Quests/");
            foreach (var file in filesq)
            {
                questList.Items.Add(withoutPath.Match(file).ToString());
            }
        }
        private void questLoadED_Click(object sender, EventArgs e)
        {
            if (questList.SelectedItem != null)
            {
                string questName = questList.SelectedItem.ToString();
                if (questName != "")
                {
                    string path = @"Quests/"+ questName + ".txt";
                    MainEditorForm m = new MainEditorForm(path);
                    m.Show();
                }
                else MessageBox.Show("К сожалению, этого квеста нет...");
            }
        }

        private void newQuestED_Click(object sender, EventArgs e)
        {
            EdtiorQuestCreation edQuCr = new EdtiorQuestCreation();
            edQuCr.Show();
        }
    }
}
