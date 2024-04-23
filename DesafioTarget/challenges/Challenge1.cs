using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.challenges
{
    public class Challenge1
    {
        public static void Run()
        {
            // int INDICE = 13, 
            // SOMA = 0, 
            // K = 0;

            // enquanto K < INDICE faça
            // {
                // K = K + 1;
                // SOMA = SOMA + K;
            // }

            // imprimir(SOMA);
            // Ao final do processamento, qual será o valor da variável SOMA?
            int index = 13;
            int sum = 0;
            int k = 0;

            while (k < index )
            {
                k++;
                sum += k;
            }

            Console.WriteLine($"The Sum is {sum}");
        }
    }
}