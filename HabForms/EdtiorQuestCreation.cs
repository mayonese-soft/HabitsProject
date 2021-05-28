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
            File.Create(@"../../Quests/" + textBoxQuestName.Text + ".txt").Close();
        }
    }
}
