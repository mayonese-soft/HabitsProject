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
    public partial class MainMenu : Form
    {
        string local_user_path;
        public MainMenu(string localPath)
        {
            InitializeComponent();
            local_user_path = localPath;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTrackerForm mainTracker = new MainTrackerForm(local_user_path);
            Hide();
            mainTracker.Show();
        }
    }
}
