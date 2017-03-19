using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypeLocalVars
{
    /*
    class ThisWillNeverComplite
    {
        //ошибка! var не может применяться к полям!
        private var myInt = 10;
        //ошибка! var не может применяться к возвращаемому значению или типу параметра!
        public var MyMethod(var x, var y) { }
    }
    */

    class Program
    {
        static void DeclareExplicitVars()
        {
            //явно типизированные локальные переменные объявляются след.образом:
            //типДанных = имяПеременной = начальноеЗначение;
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";
        }

        static void DeclareImplicitVars()
        {
            //неявно типизированные локальные переменные объявляются след.образом:
            //var имяПеременной = начальноеЗначение;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            //вывести имена лежащих в основе типов
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        /*
        static void ImplicitTypingIsStrongTyging()
        {
            //компилятор знает, что s имеет тип System.String
            var s = "This variable can only hold string data!";
            s = "This is fine...";
            //можно вызвать любой член лежащего в основе типа
            string upper = s.ToUpper();
            //ошибка! присваивание числовых дынный стороке не допускается!
            s = 44;
        }
        */

        static void LinqQuertyOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //запрос LINQ!
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();
            //к какому типу относится subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defines in: {0}", subset.GetType().Namespace);
        }

        static void Main(string[] args)
        {
            DeclareImplicitVars();
            LinqQuertyOverInts();
        }
    }
}
