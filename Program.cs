using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] question = { "четрые или пять?", "сколько ног у осьминога", "сколько пар завтра", "сколько время", "как ты?", "нормас" };
            string[] answer = { "5", "7", "4", "9:52", "норма", "ое" };
            int countCorrectAnswer = 0;
            for (int i = 0; i < 5; i++)
            {
                
                int randomQuest = new Random().Next(0, question.Length);

                Console.WriteLine(question[randomQuest]);
                string userAnswer = Console.ReadLine();
                if (question[randomQuest] == userAnswer)
                {
                    countCorrectAnswer++;
                }
            }
            Console.WriteLine(countCorrectAnswer);
        }
    }
}
