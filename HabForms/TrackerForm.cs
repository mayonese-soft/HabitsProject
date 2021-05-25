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
            List<Habits> habits = new List<Habits>();
            using (StreamReader sr = new StreamReader("userData.csv"))
            {
                while (sr.EndOfStream != true)
                {
                    string[] str = sr.ReadLine().Split(';');
                    habits.Add(new Habits() { hab_numb = Convert.ToInt32(str[0]), name = str[1], question = str[2], isGood = Convert.ToBoolean(str[3])});
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
