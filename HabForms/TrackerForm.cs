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
    public partial class TrackerForm : Form
    {
        public TrackerForm()
        {
            InitializeComponent();
            string[] activities;
            using (StreamReader sr = new StreamReader("userData.csv"))
            {
                List<Habits> habits = new List<Habits>();
                int i = 0; 
                while (sr.EndOfStream != true)
                {
                    string[] str = sr.ReadLine().Split(';');
                    activities[i] = habits.
                    //userList.Add(new Users() { login = str[0], pass = str[1], score = Convert.ToInt32(str[2]) });
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
