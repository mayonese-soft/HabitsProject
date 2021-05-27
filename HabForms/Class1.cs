using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HabitsProject
{
    public class Quests
    {

        public void Quest()
        {
            Console.WriteLine("Квест");
            QuestInterf q = new QuestInterf();
            string Path = "qst1.txt";
            q.answ = '0';
            foreach (var line in File.ReadAllLines(Path))
            {
                Console.WriteLine(line);
                if (line.Contains("<>"))
                {
                    q.answ = Convert.ToChar(Console.Read());
                    foreach (var line1 in File.ReadAllLines(Path))
                    {
                        if (line1.Contains(q.answ)) break;
                    }
                }
                if (line.Contains('/'))
                {
                    break;
                }
            }
        }

    }
}