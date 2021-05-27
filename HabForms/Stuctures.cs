﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabForms
{
    struct QuestInterf
    {
        public string text;
        public int answ;
    }
    [Serializable]
    struct Users
    {
        public string login;
        //public byte[] pass;
        public string pass;
    }
    [Serializable]
    struct Page
    {
        public string pageID;
        public string imageLink;
        public string mainText;
        public string fVar;
        public string sVar;
        public string tVar;
        public string fLink;
        public string sLink;
        public string tLink;
    }
}