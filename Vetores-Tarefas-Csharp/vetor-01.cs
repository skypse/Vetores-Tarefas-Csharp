using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nome     : Gabriel do Amaral Alves
// Data     : 16/06/2024
// Enunciado: 1) Soma dos Elementos: Escreva um programa que calcule
// a soma de todos os elementos de um vetor de inteiros.


namespace Vetores_Tarefas_Csharp
{
    internal class vetor_01
    {
        public static void Main(string[] args)
        {
            int[] vetor_inteiros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            Console.WriteLine($"A soma total dos elementos do vetor é: {vetor_inteiros.Sum()}");
        }
    }
}
