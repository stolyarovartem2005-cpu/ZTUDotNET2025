using System;
using StringExtensionsLib;

namespace StringExtensionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello Extension Methods";

            Console.WriteLine("Original string:");
            Console.WriteLine(text);

            Console.WriteLine("\nReversed string:");
            Console.WriteLine(text.ReverseString());

            char symbol = 'e';
            int count = text.CountOccurrences(symbol);

            Console.WriteLine($"\nNumber of occurrences of '{symbol}': {count}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
