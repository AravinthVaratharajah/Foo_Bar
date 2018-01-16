using System;
using System.Text.RegularExpressions;

namespace Foo_Bar
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = "";

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    message = message + "Foo";

                if (i % 5 == 0)
                    message = message + "Bar";

                if (i % 7 == 0)
                    message = message + "Qix";

                if (Regex.Matches(i.ToString(), "3").Count == 1)
                    message = message + "Foo";
                else if (Regex.Matches(i.ToString(), "3").Count == 2)
                    message = message + "FooFoo";

                if (Regex.Matches(i.ToString(), "5").Count == 1)
                    message = message + "Bar";
                else if (Regex.Matches(i.ToString(), "5").Count == 2)
                    message = message + "BarBar";

                if (Regex.Matches(i.ToString(), "7").Count == 1)
                    message = message + "Qix";
                else if (Regex.Matches(i.ToString(), "7").Count == 2)
                    message = message + "QixQix";

                if(string.IsNullOrEmpty(message))
                    Console.WriteLine(i);
                else
                    Console.WriteLine(message);
                
                message = "";
            }
        }
    }
}
