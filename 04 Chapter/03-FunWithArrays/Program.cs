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
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimentionalArray();
            PassAndReceiveArrays();
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

        #region неявно типизированные локальные массивы var
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

        #region определение массива объектов object[]
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            //массив объектов может содержать всё что угодно
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                //вывести тип и значение каждого элемента в массиве
                Console.WriteLine("Type: {0}, Valye: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }
        #endregion

        #region прямоугольный многомерный массив
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            //прямоугольный многомерный массив
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            //заполнить массив 6*6
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }
            //вывести массив 6*6
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");                    
                }
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        #endregion

        #region зубчатый многомерный массив
        static void JaggedMultidimentionalArray()
        {
            Console.WriteLine("=> Jagged multidimentional array.");
            //зубчатый многомерный массив (т.е. массив массивов)
            //здесь мы имеем массив из 5 разных массивов
            int[][] myJagArray = new int[5][];
            //создать зубчатый массив
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            //вывести каждую строку (каждый элемент имеет стандартное значение 0)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");                   
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion

        #region использование массивов в качестве аргументов и возвращаемых значений
        //первый метод принимает входящий массив значений int и выводит все его эл.на консоль
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine($"Item {i} is {myInts[i]}");
            }
        }

        //второй метод заполняет массив и возвращает его вызывающему коду
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        //эти два метода могут быть вызваны след.образом
        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            //передать массив в качестве параметра
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);
            //получить массив в качестве возвращаемого значения
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
