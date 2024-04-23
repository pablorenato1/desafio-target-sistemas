using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.challenges
{
    public class Challenge2
    {
       // Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        // IMPORTANTE:

        // Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
        public static void IsAFibonacciNumber(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            if (b == number)
            {
                Console.WriteLine($"The number {number} is in the Fibonacci Sequence.");
            } 
            else
            {
                Console.WriteLine($"The number {number} is NOT in the Fibonacci Sequence.");
            }
        }
 
    }
}