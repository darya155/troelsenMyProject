using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            //добавить две переменных типа short и вывести результат
          /*short numb1 = 9, numb2 = 10;
            Console.WriteLine($"{numb1} + {numb2} = {Add(numb1, numb2)}");
            Console.ReadLine();*/

            short numb1 = 30000, numb2 = 30000;
            /*
             //ошибка, т.к. не просто выводим в консоль ответ, а сохраняем
             //в переменной типа short
             short answer = Add(numb1, numb2);  
             Console.WriteLine($"{numb1} + {numb2} = {answer}");
            */

            //явно приводим int к short (и разрешаем потерю данных), используем операцию приведения "()"
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine($"{numb1} + {numb2} = {answer}");
            NarrowingAttempt();
            ProcessBytes();
        }
        static int Add(int x, int y) //метод
        {
            return x + y;
        }
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            /*myByte = myInt; //ошибка*/
            //явно приводим int к byte (без потери данных)
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            /*
            byte sum = (byte)Add(b1, b2);
            //в sum должно содержаться значение 350, однако там оказывается значение 94. 
            //т.е. 94 - это (350 - 256(диапазон byte 0-255) = 94)
            Console.WriteLine("sum = {0}", sum);
            */
            /*
            //на этот раз сообщить компилятору о необходимости добавления CIL-кода, необходимого 
            //для генерации исключения, если возникает переполнение или потеря значимости
            try
            {
                byte sum = checked((byte)Add(b1, b2)); //тут пишем checked
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            //применяем проверку переполнения к блоку операторов:
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }

            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
