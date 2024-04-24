using System;
using System.Collections.Generic;

namespace DesafioTarget.challenges
{
    public class Challenge3
    {
        public static void IdentifyNextElement(string[] args)
        {
            List<int> sequence = new List<int> { 1, 4, 9, 16, 25, 36 };

            List<int> nextSequence = IdentifyNextElement(sequence);

            Console.WriteLine("Next Element in Sequence: ");
            foreach (int element in nextSequence)
            {
                Console.Write(element + " ");
            }
        }

        public static List<int> IdentifyNextElement(List<int> sequence)
        {
            List<int> nextSequence = new List<int>();

            string sequenceType = IdentifySequenceType(sequence);
            switch (sequenceType)
            {
                case "Arithmetic":
                    nextSequence = GetNextArithmeticSequence(sequence);
                    break;
                case "Geometric":
                    nextSequence = GetNextGeometricSequence(sequence);
                    break;
                case "Fibonacci":
                    nextSequence = GetNextFibonacciSequence(sequence);
                    break;
                case "Squared":
                    nextSequence = GetNextSquaredSequence(sequence);
                    break;
                // case "SquaredEven":
                //     nextSequence = GetNextSquaredEvenSequence(sequence);
                //     break
                default:
                    Console.WriteLine("Unknown sequence type.");
                    break;
            }

            return nextSequence;
        }

        public static string IdentifySequenceType(List<int> sequence)
        {
            if (IsArithmetic(sequence))
            {
                return "Arithmetic";
            }
            else if (IsGeometric(sequence))
            {
                return "Geometric";
            }
            else if (IsFibonacci(sequence))
            {
                return "Fibonacci";
            }
            else if (IsSquaredSequence(sequence))
            {
                return "Squared";
            }
            else if (IsSquaredSequence(sequence))
            {
                return "SquaredEven";
            }
            else
            {
                return "Unknown";
            }
        }

        public static bool IsArithmetic(List<int> sequence)
        {
            if (sequence.Count < 2)
            {
                return false;
            }

            int commonDifference = sequence[1] - sequence[0];
            for (int i = 1; i < sequence.Count - 1; i++)
            {
                if (sequence[i + 1] - sequence[i] != commonDifference)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsGeometric(List<int> sequence)
        {
            if (sequence[0] == 0)
            {
                sequence.RemoveAt(0);
            }

            int ratio = sequence[1] / sequence[0];
            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i] / sequence[i - 1] != ratio)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsFibonacci(List<int> sequence)
        {
            if (sequence.Count < 3)
            {
                return false; // Not enough elements to determine if Fibonacci
            }

            for (int i = 2; i < sequence.Count; i++)
            {
                if (sequence[i] != sequence[i - 1] + sequence[i - 2])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSquaredSequence(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] != (i + 1) * (i + 1))
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetNextArithmeticSequence(List<int> sequence)
        {
            int commonDifference = sequence[1] - sequence[0];
            int nextElement = sequence[sequence.Count - 1] + commonDifference;
            sequence.Add(nextElement);
            return sequence;
        }

        public static List<int> GetNextGeometricSequence(List<int> sequence)
        {
            int commonRatio = sequence[1] / sequence[0];
            int nextElement = sequence[sequence.Count - 1] * commonRatio;
            sequence.Add(nextElement);
            return sequence;
        }

        public static List<int> GetNextFibonacciSequence(List<int> sequence)
        {
            int nextElement = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
            sequence.Add(nextElement);
            return sequence;
        }

        public static List<int> GetNextSquaredSequence(List<int> sequence)
        {
            int nextIndex = sequence.Count + 1;
            int nextElement = nextIndex * nextIndex;
            sequence.Add(nextElement);
            return sequence;
        }
    }
}
