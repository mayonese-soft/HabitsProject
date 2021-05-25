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
            using (StreamReader sr = new StreamReader("habitData.csv"))
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
            }
            var source = new AutoCompleteStringCollection();
            source.AddRange(activities);
            foreach (object obj in source)
            {
                listBox1.Items.Add(obj);
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
