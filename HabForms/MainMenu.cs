﻿using System;
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
        public static MainMenu instance;

        public MainMenu()
        {
            InitializeComponent();
            FormClosing += MainMenu_FormClosing;
            instance = this;
        }

        private void MainMenu_FormClosing(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MainTrackerForm mainTracker = new MainTrackerForm();
            //Hide();
            //mainTracker.Show();
        }

        private void questsButton_Click(object sender, EventArgs e)
        {
            StartQuestMenu startQuestMenu = new StartQuestMenu();
            Hide();
            startQuestMenu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditorEntry edEn = new EditorEntry();
            Hide();
            edEn.Show();
            //MainEditorForm mainEditorForm = new MainEditorForm("qst1.txt");
            //mainEditorForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settingForm = new Settings();
            Hide();
            settingForm.Show();
        }
    }
}
