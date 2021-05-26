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
        List<Habits> habits = new List<Habits>();

        public TrackerForm()
        {
            InitializeComponent();
            LoadHabitList();
            LoadActivities();
        }

        private void LoadHabitList()
        {
            using (StreamReader sr = new StreamReader("habitData.csv", Encoding.UTF8, true))
            {
                while (sr.EndOfStream != true)
                {
                    string[] str = sr.ReadLine().Split(';');
                    habits.Add(new Habits() { hab_numb = Convert.ToInt32(str[0]), name = str[1], question = str[2], isGood = Convert.ToBoolean(str[3]) });
                }
            }
        }

        private void LoadActivities()
        {
            int i = 0;
            string[] activities = new string[habits.Count];
            foreach (Habits habit in habits)
            {
                activities[i] = habit.name;
                i++;
            }
            listBox1.Items.AddRange(activities);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moveItems_Click(object sender, EventArgs e)
        {

        }
    }
}
