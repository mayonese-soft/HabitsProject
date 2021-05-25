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
    struct Habits // структура для полезных и вредных привычек
    {
        public int hab_numb;
        public string quastion;
        public double answer;
        public bool isGood; // флаг для определения привычки
    }    
    struct DaylyHabits // структура для ежедвевных привычек
    {
        public int hab_numb;
        public bool isDone;
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
        public List<Habits> good_bad_hab;
        public List<DaylyHabits> d_hab;
    }
    struct HabProgress
    {
        public int prog_numb;
        public DateTime date;
        public List<object> hab;        
    }
    
}