using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitsProject
{
    struct Habits // структура для полезных и вредных привычек
    {
        int hab_numb;
        string quastion;
        int answer;
    }    
    struct DaylyHabits // структура для ежедвевных привычек
    {
        int hab_numb;
        bool did_or_not;
    }
    struct Users
    {
        int user_numb;
        string login;
        byte[] pass;
        object[] habs;
    }
}