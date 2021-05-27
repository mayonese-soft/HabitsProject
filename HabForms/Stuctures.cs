using System;
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
        public string mainText;
        public string fAnswer;
        public string sAnswer;
        public string tAnswer;
        public string fLink;
        public string sLink;
        public string tLink;
    }
}