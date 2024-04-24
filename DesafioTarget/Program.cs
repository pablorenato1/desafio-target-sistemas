using System;
using DesafioTarget.challenges;
class Program
{
        static void Main(string[] args)
        {
            // Example sequences
            // List<int> sequenceA = new List<int> { 1, 3, 5, 7 };
            // List<int> sequenceB = new List<int> { 2, 4, 8, 16, 32, 64 };
            List<int> sequenceC = new List<int> { 0, 1, 4, 9, 16, 25, 36 };
            List<int> sequenceD = new List<int> { 4, 16, 36, 64 };
            // List<int> sequenceE = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            List<int> sequenceF = new List<int> { 2, 10, 12, 16, 17, 18, 19 };

            // Print the next elements in the sequences
            // PrintNextElement(sequenceA);
            // PrintNextElement(sequenceB);
            PrintNextElement(sequenceC);
            PrintNextElement(sequenceD);
            // PrintNextElement(sequenceE);
            PrintNextElement(sequenceF);
        }

        static void PrintNextElement(List<int> sequence)
        {
            try
            {
                List<int> nextElement = Challenge3.IdentifyNextElement(sequence);
                Console.WriteLine($"Next element in sequence [{string.Join(", ", sequence)}]: {sequence[sequence.Count-1]}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
}