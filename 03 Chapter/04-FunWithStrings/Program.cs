﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            StringConcatenation2();
            EscapeChars();
            StringEquality();
            StringsAreImmutable();
            StringsAreImmutable2();
            FunWithStringBuilder();
            Console.ReadLine();

        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replase: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        static void StringConcatenation2()
        {
            Console.WriteLine("=> String concatenation_2:");
            string s1 = "Programming the ";
            string s2 = "PsyhoDyill (PTP)";
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWhithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWhithTabs);
            Console.ReadLine();

            Console.WriteLine("Everyone loves \"Hello Word\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debag\a ");
            Console.ReadLine();

            //Adds a total of 4 blank lines (then beep again!)
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.ReadLine();
            Console.WriteLine();

            //The following string is printed verbatim, thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            Console.WriteLine();

            //Wtite spase is preserved with verbatim strings.
            string myLongString = @"This is a very
                very
                        very
                                long string";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Cerebus said ""Darr! Pret-ty sun-sets""");
        }
        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Test these strings equality
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }
        static void StringsAreImmutable()
        {
            //Set initial string value
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            //Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            //Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
        }
        static void StringsAreImmutable2()
        {
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
        }
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder: ");
            StringBuilder sb = new StringBuilder("***Fantastic Games***", 256);
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

    }
}

