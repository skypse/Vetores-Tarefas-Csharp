using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
// Nome     : Gabriel do Amaral Alves
// Data     : 16/06/2024
// Enunciado: 3) Média dos Elementos: Desenvolva um programa que calcule
// a média dos elementos em um vetor de números reais.

namespace Vetores_Tarefas_Csharp_03
{
    internal class vetor_03
    {
        public static void Main(string[] args)
        {
            int[] vetor_inteiros = { 1, 5, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12, };

            double soma = 0;
            // percorrer o vetor
            for (int i = 0; i < vetor_inteiros.Length; i++)
            {
                soma += vetor_inteiros[i];
            }

            // media
            double media = soma / vetor_inteiros.Length;

            Console.WriteLine($"A média dos elementos: {media:F2}");
        }
    }
}
