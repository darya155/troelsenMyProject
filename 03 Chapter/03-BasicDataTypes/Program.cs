using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStrings();
            UseDatesAndTimes();
            UseBigeInteger();
            Console.ReadLine();
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=>Data Declarations:");
            //Local variables are declared as so: dataType varName; declared and initialized as: dataType varName = initialValue
            //By one line:
            int myInt = 0;
            //You can also declared assign on two lines
            //one:
            string myString;
            //two:
            myString = "This is my character data";

            //Declare 3- bools type variables on a singl/one line
            bool b1 = true, b2 = false, b3 = b1;

            //Use System.Boolean data type to declare a bool
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using <<new>> to create variables:");
            bool b = new bool(); //set to jalse
            int i = new int(); //set to 0
            double d = new double(); //set to 0
            DateTime dt = new DateTime(); //set to 1/1/0001 12:00:00 am
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // a C# int really a shorthand for System.Int32, which inherits the following members from System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();

        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();

            Console.WriteLine("=> Members of System.Boolean");
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");

            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");

            //This constructor takes (year, month, day)
            DateTime dt = new DateTime(2011, 10, 17);

            //What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //Month is now Desember
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            //This constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            //Subtract 15 minutes from the current TimeSpan and print the result
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }
        static void UseBigeInteger()
        {
            Console.WriteLine("=> Use BigeInteger:");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            //biggy четное?
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            //biggy степень 2?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy,
            BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            BigInteger reallyBig2 = biggy * reallyBig;
            Console.WriteLine("Value of reallyBig2 is {0}", reallyBig2);

        }
    }
}
