using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        //note, we are now returning at int, rather then void. Вводим int, а не void.
        static int Main(string[] args)
        {
            //Display a simple message to the user. Выводим простое сообщение для пользователя.
            Console.WriteLine("****My first C# App****");
            Console.WriteLine("Hello, Word!");
            Console.WriteLine();
            /*
            //Process any incoming args. Обработать любые входные аргументы.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);

             
            //Process any incoming args. using foreach. Обработать любые входящие аргументы, используя foreach
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);
            */
            //Get arguments using Sistem.Enviroment. Получить аргументы, используя Sistem.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            //Helper method within the Programm class. Вспомогательный метод внутри класса Programm.
            ShowEnvironmentDetails();

            //Wait for "Enter" key to be press before shutting down. Перед завершением работы нажать Энтер.
            Console.ReadLine();

            //Return an arbitrary error code. Возвратить произвольный код ошибки.
            return -1;

        }
        static void ShowEnvironmentDetails()
        {
            //Print out the drives on this machine, and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}

