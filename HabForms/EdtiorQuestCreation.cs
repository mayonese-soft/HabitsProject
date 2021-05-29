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
using System.Text.RegularExpressions;

namespace HabForms
{
    
    public partial class EdtiorQuestCreation : Form
    {
        public EdtiorQuestCreation()
        {
            InitializeComponent();
        }

        private void questCreateButton_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("[A-zА-я0-9]{1,}");
            if (r.IsMatch(textBoxQuestName.Text))
            {
                File.Create(@"Quests/" + r.Match(textBoxQuestName.Text) + ".txt").Close();
                Close();
            }
            else MessageBox.Show("Введите название квеста!");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
