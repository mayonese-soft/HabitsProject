using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
