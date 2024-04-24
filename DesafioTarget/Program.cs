using System;
using DesafioTarget.challenges;
class Program
{
        static void Main(string[] args)
        {
            /// Sum Challenge
            // Challenge1.Run();

            // Fibonacci Challenge
            // Challenge2.IsAFibonacciNumber(380);

            // Reverse String
            string word = "Banana"; // Word to be reversed
            string reversedWord = Challenge5.ReverseString(word);
            Console.WriteLine("Original word: " + word);
            Console.WriteLine("Reversed word: " + reversedWord);
        }
}