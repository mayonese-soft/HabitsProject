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
    public partial class Settings : Form
    {
        public static bool autosaveIsOn;
        public Settings()
        {
            InitializeComponent();
            FormClosing += Settings_OnClosing;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Settings_OnClosing(object sender, EventArgs e)
        {
            autosaveIsOn = isAutosaveOn.Checked;

        }
    }
}
