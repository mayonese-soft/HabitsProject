using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            CheckAutosaveIsOn();
            FormClosing += Settings_OnClosing;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.instance.Show();
        }
        private void Settings_OnClosing(object sender, EventArgs e)
        {
            autosaveIsOn = isAutosaveOn.Checked;
            using (StreamWriter sw = new StreamWriter(Form1.local_user_path + "/Data.csv"))
            {
                sw.WriteLine(autosaveIsOn.ToString());
            }
        }
        private void CheckAutosaveIsOn()
        {
            using (StreamReader sw = new StreamReader(Form1.local_user_path + "/Data.csv"))
            {
                isAutosaveOn.Checked = Convert.ToBoolean(sw.ReadLine());
            }
        }
    }
}
