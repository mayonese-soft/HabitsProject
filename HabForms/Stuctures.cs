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
        public int score;
    }
    struct UserHabs
    {
        public string login;
    }
}