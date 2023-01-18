using System;
using MyNewApp.Utilities;
using MyNewApp.createObject;

/*
    MyNewApp is the Lowest level and owns Program, Utilities, and createObject
*/
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

            Marker newMarker = new Marker("Blue");
            Console.WriteLine(newMarker.getColor());
            newMarker.changeColor("Red");
            Console.WriteLine(newMarker.getColor());
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

namespace MyNewApp.createObject
{
    class Marker
    {
        private string color;

        private int inkLevel;

        public Marker(string colorIn)
        {
            this.color = colorIn;
            this.inkLevel = 100;
        }

        public void changeColor(string newColor)
        {
            if(newColor != null){
                this.color = newColor;
            }
        }

        public string getColor()
        {
            return this.color;
        }
    }
}
