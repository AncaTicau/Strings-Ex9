using System;

namespace Strings_Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeSpaces = RemoveSpaces("  This is a string with   spaces!");

            Console.WriteLine(removeSpaces);
        }

        //Write a method to remove spaces from a given string.

        public static string RemoveSpaces(string input)
        {
            string result = input.Replace(" ", String.Empty);

            return result;
        }
    }
}
