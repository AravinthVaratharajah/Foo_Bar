using System;
using System.Text.RegularExpressions;

namespace Foo_Bar
{
    public class Program
    {
        static void Main(string[] args)
        {
            var message = "";

            for (int i = 1; i < 101; i++)
            {
                message = IsDivisibleByThree(message, i);
                message = IsDivisibleByFive(message, i);
                message = IsDivisibleBySeven(message, i);
                message = ContainsThree(message, i);
                message = ContainsFive(message, i);
                message = ContainsSeven(message, i);
                CheckMessageEmpty(message, i);
                message = "";
            }
        }

        public static string IsDivisibleByThree(string message, int i)
        {
            if (i % 3 == 0)
                message += "Foo";
            return message;
        }

        public static string IsDivisibleByFive(string message, int i)
        {
            if (i % 5 == 0)
                message += "Bar";
            return message;
        }

        public static string IsDivisibleBySeven(string message, int i)
        {
            if (i % 7 == 0)
                message += "Qix";
            return message;
        }
        public static string ContainsThree(string message, int i)
        {
            if (Regex.Matches(i.ToString(), "3").Count == 1)
                message += "Foo";
            else if (Regex.Matches(i.ToString(), "3").Count == 2)
                message += "FooFoo";
            return message;
        }

        public static string ContainsFive(string message, int i)
        {
            if (Regex.Matches(i.ToString(), "5").Count == 1)
                message += "Bar";
            else if (Regex.Matches(i.ToString(), "5").Count == 2)
                message += "BarBar";
            return message;
        }

        public static string ContainsSeven(string message, int i)
        {
            if (Regex.Matches(i.ToString(), "7").Count == 1)
                message += "Qix";
            else if (Regex.Matches(i.ToString(), "7").Count == 2)
                message += "QixQix";
            return message;
        }

        public static void CheckMessageEmpty(string message, int i)
        {
            if (string.IsNullOrEmpty(message))
                Console.WriteLine(i);
            else
                Console.WriteLine(message);
        }
    }
}
