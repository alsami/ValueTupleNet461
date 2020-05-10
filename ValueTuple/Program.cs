using System;

namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            (string a, string b) = ("a", "b");
            Console.WriteLine("Hello World!");
        }
    }
}