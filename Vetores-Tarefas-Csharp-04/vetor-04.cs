using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nome     : Gabriel do Amaral Alves
// Data     : 16/06/2024
// Enunciado: 4) Vetor Invertido: Implemente um programa que inverta a ordem dos
// elementos em um vetor.

namespace Vetores_Tarefas_Csharp_04
{
    internal class vetor_04
    {
        public static void Main(string[] args)
        {
            int[] vetor_inteiros = { 9, 2, 3, 5 };

            int comprimento = vetor_inteiros.Length; // = 4

            for (int i = 0; i < comprimento / 2; i++)
            {
                // armazena temporariamente
                int troca = vetor_inteiros[i]; // troca = 9
                // substitui o valor do elemento atual pelo valor do último elemento
                vetor_inteiros[i] = vetor_inteiros[comprimento - 1 - i]; // vetor_inteiros[0] = 5
                vetor_inteiros[comprimento - 1 - i] = troca; // vetor_inteiros[3] = 9
            }

            Console.WriteLine("O vetor invertido ficou:");
            for (int i = 0; i < vetor_inteiros.Length; i++)
            {
                Console.Write(vetor_inteiros[i] + " ");
            }
        }
    }
}
