using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplisitArrays();
        }

        #region создание и заполнение простого массива
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            //создать массив int, содержащий 3 элемента
            // с индексами 0,1,2 и заполнить его
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            //вывести все значения
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }

            //создать массив string, содержащий 100 элементов
            //с индексами 0-99;
            string[] booksOnDotNet = new string[100];
        }
        #endregion

        #region синтаксис инициализации массивов
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");
            //синтаксис инициализации массива
            //с испльзованием ключевого слова new
            string[] stringArray = new string[]
                {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            //синтаксис инициализации массива
            //без использования ключевого слова new
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //синтаксис инициализации массива
            //с использованием ключевого слова new и размера
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        #endregion

        #region неявно типизированные локальные массивы
        static void DeclareImplisitArrays()
        {
            Console.WriteLine("=> Implisit Arrray Initialisation.");
            //а - на самом деле int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            //b - на самом деле double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            //с - на самом деле string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        #endregion
    }
}
