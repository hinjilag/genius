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
            // поправить названия функций и переменных
            string[] question =
            {
                "четрые или пять?",
                "сколько ног у осьминога",
                "сколько пар завтра",
                "сколько время",
                "gg"
            };
            string[] answer = { "5", "7", "4", "9:52", "dobeg" };

            int countCorrectAnswer = 0;

            Console.WriteLine("Как вас зовут?");
            string nameUser = Console.ReadLine();
            Console.WriteLine($"Отлично, {nameUser}, отвечай на вопросы, и узнаешь свой диагноз");
            Console.WriteLine("Готов ?");
            string userMessege = Console.ReadLine();

            while (YesOrNo(userMessege) == false)
            {
                Console.WriteLine("Такого варианта нет. Готов?");

                userMessege = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < question.Length; i++) // сам тест 
            {
                Console.WriteLine(question[i]);
                string userAnswer = Console.ReadLine();
                if (answer[i] == userAnswer)
                {
                    countCorrectAnswer++;
                }
            }

            string diagnosis = DefinitDiagnosis(countCorrectAnswer);

            Console.WriteLine();

            Console.WriteLine($"Количество баллов: {countCorrectAnswer}");
            Console.WriteLine($"{nameUser}, твой диагноз: {diagnosis}");

            Console.WriteLine();

            Console.WriteLine("Сыграем еще раз?");
            userMessege = Console.ReadLine();
            while (YesOrNo(userMessege) == false)
            {
                Console.WriteLine("непраильнвый ответ, давай еще раз");
                Console.WriteLine("Сыграем еще раз?");
                Console.WriteLine();
                userMessege = Console.ReadLine();
            }
        }




        static string DefinitDiagnosis(int countCorrectAnswer)
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

        static bool YesOrNo(string messege)
        {
            if (messege == "да" || messege == "Да" || messege == "ДА")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
