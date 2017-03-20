using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ForLoopExemple();
            ForEachLoopExample();
            LinqQeryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            SwichExample();
            SwitchOnStringExample();
            */
            SwitchOnEnumExample();
        }

        static void ForLoopExemple()
        {
            //переменная i видима только в контексте этого цикла for
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Numbers is: {0} ", i);
            }
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMV", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void LinqQeryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //запрос LINQ
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine($"{i}");
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";
            //проверить строку в нижнем регистре
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        static void SwichExample()
        {
            Console.WriteLine("1 [c#], 2 [vb]");
            Console.WriteLine("Please pick your language preferense: "); //выберете предпочитаемый язык
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, c# is a fine language");
                break;
                case 2:
                    Console.WriteLine("vb - oop, multithreading, and more!");
                break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                break;
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("c# or vb ?");
            Console.WriteLine("Please, pick your language preference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "c#":
                    Console.WriteLine("Good choice, c# is a fine language");
                    break;
                case "vb":
                    Console.WriteLine("vb - oop, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck wich that!");
                    break;
            }
        }

        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes! Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Gread day indeed.");
                    break;
                default:
                    break;
            }
        }
    }
}
