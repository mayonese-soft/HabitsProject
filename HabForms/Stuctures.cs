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
        public int answer;
        public bool good_or_bad; // флаг для определения привычки
    }    
    struct DaylyHabits // структура для ежедвевных привычек
    {
        public int hab_numb;
        public bool did_or_not;
    }
    struct Users
    {
        public int user_numb;
        public string login;
        public byte[] pass;
        public object[] habs;
        public int score;
    }
    struct HabProgress
    {
        public int prog_numb;
        public DateTime date;
        public object[] hab;        
    }
    
}