using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] question = { "четрые или пять?", "сколько ног у осьминога", "сколько пар завтра", "сколько время", "gg" };
            string[] answer = { "5", "7", "4", "9:52", "dobeg" };

            int countCorrectAnswer = 0;

            Console.WriteLine("Как вас зовут?");

            string nameUser = Console.ReadLine();

            Console.WriteLine($"Отлично, {nameUser} ,отвечай на вопросы, и узнаешь свой диагноз");

            Console.WriteLine();
            for (int i = 0; i < 5; i++) // сам тест 
            {
                Console.WriteLine(question[i]);
                string userAnswer = Console.ReadLine();
                if (answer[i] == userAnswer)
                {
                    countCorrectAnswer++;
                }
            }
            string Diagnosis = DefinitionDiagnosis(countCorrectAnswer);
            Console.WriteLine();
            Console.WriteLine($"Количество баллов: {countCorrectAnswer}");
            Console.WriteLine($"{nameUser}, твой диагноз: {Diagnosis}");

        }
        



        static string DefinitionDiagnosis(int countCorrectAnswer)
        {
            string diagnoz = "";
            if (countCorrectAnswer == 0)
                diagnoz = "бедолага";
            else if (countCorrectAnswer == 1)
                diagnoz = "дурак";
            else if (countCorrectAnswer == 2)
                diagnoz = "дурик";
            else if (countCorrectAnswer == 3)
                diagnoz = "жить будешь";
            else if (countCorrectAnswer == 4)
                diagnoz = "тип";
            else if (countCorrectAnswer == 5)
                diagnoz = "тынг тип!!!";
            return diagnoz;
        }


    }
}
