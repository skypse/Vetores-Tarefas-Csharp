using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nome     : Gabriel do Amaral Alves
// Data     : 16/06/2024
// Enunciado: 2) Maior e Menor Valor: Crie um programa que encontre
// o maior e o menor valor em um vetor de números inteiros.

namespace Vetores_Tarefas_Csharp_02
{
    internal class vetor_02
    {
        public static void Main(string[] args)
        {
            int[] vetor_inteiros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };

            // Máximo
            Console.WriteLine($"O maior elemento do vetor: {vetor_inteiros.Max()}");

            // Mínimo
            Console.WriteLine($"O menor elemento do vetor: {vetor_inteiros.Min()}");
        }
    }
}
