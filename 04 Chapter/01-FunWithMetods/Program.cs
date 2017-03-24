using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FunWithMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            //передать две переменные по значению (pass two variables by value)
            int x = 9, y = 10;
            Console.WriteLine($"Before call: X: {x}, Y: {y}");
            Console.WriteLine($"Answer is: {Add(x,y)}");
            Console.WriteLine($"After call: X: {x}, Y: {y}");
            Console.WriteLine();

            //присваивать начальные значения локальным переменным,
            //используемым как входные параметры, не обязательно,
            //при условии, что в таком качестве они используются первый раз.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine($"90 + 90 = {ans}");
            Console.WriteLine();

            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine($"Int is: {i}");
            Console.WriteLine($"String is: {str}");
            Console.WriteLine($"Bool is: {b}");
            Console.WriteLine();

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine($"Before: {str1}, {str2}");
            SwapStrings(ref str1, ref str2);
            Console.WriteLine($"After: {str1}, {str2}");
            Console.WriteLine();

            //передать разделяемый запятыми список значений double
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            //или передать массив значений double
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            //среднее из 0 равно 0
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.WriteLine();

            EnterLogData("Oh no! Grid can`t find data");
            EnterLogData("Oh no! I can`t find the payroll data", "CFO");
            Console.WriteLine();


            DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Testing...",
                textColor: ConsoleColor.DarkBlue);
            Console.WriteLine();

            
            DisplayFancyMassageNext(message: "Hello!");
            DisplayFancyMassageNext(backgroundColor: ConsoleColor.Green);
        }

        #region Pass by value
        //по умолчанию аргументы передаются по значению (аргументы-это переменные?)
        static int Add(int x, int y)
        {
            int ans = x + y;
            //вызывающий код не увидит эти изменения,
            //т.к. изменяется копия исходных данных.
            x = 10000;
            y = 88888;
            return ans;
        }
        #endregion

        #region By reference via out keyword
        //значения выходных параметров должны быть 
        //установлены вызываемым методом
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        //возврат множества выходных параметров
        //returning multiple output parametrs
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Engoy your string";
            c = true;
        }
        #endregion

        #region By reference via ref keyword
        //ссылочные параметры (reference parametrs)
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        #endregion

        #region params keyword
        //возвращение среднего из некоторого количества значений double
        //return average of "some number" of doubles
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        #endregion

        #region необязательные параметры (optional/names params)
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }
        #endregion

        #region Приминение именованных аргументов - 1
        static void DisplayFancyMessage(ConsoleColor textColor, 
            ConsoleColor backgroundColor, string message)
        {
            //сохранить старые цвета с целью их 
            //восстановления после вывода сообщения.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //установить новые цвета и вывести сообщение
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //восстановить предыдущие цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
        #endregion

        #region Применение именовынных аргументов - 2
        static void DisplayFancyMassageNext(ConsoleColor textColor = ConsoleColor.Blue, 
            ConsoleColor backgroundColor = ConsoleColor.White, 
            string message = "Test Message")
        {
            //сохранить старые цвета с целью их 
            //восстановления после вывода сообщения.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //установить новые цвета и вывести сообщение
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //восстановить предыдущие цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        #endregion
    }
}
