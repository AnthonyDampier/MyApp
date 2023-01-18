using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            int countLetters = Utility.CountLetters(value);
            Console.WriteLine($"Secret message: {reversedValue}");
            Console.WriteLine($"Message length: {countLetters}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        /* 
        Returns message in reverse order
        */
        public static string Reverse(string message)
        {
            char[] letters = (message).ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
        /*
        Return int for number of letters in message
        */
        public static int CountLetters(string message)
        {
            int i = 0;
            char[] letters = (message).ToCharArray();
            foreach (var letter in letters){
                if(letter != ' '){
                    i++;
                }
            }
            return i;
        }
    }
}


