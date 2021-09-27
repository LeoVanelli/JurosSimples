using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule o montante final de um investimento a juros simples.

            Console.WriteLine("         Juros Simples (j)         \n");

            Console.WriteLine("Insira as informações solicitadas a seguir:\n");

            Console.Write("Capital [c] (R$).......: ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("Taxa de juros [i] (%)..: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Tempo [t] (meses)......: ");
            int t = int.Parse(Console.ReadLine());

            float j = ((c*i)/100)*t;

            Console.WriteLine($"\nJuros (R$) ............: {j}");
            Console.WriteLine($"Montante (R$)......: {c+j}");
        }
    }
}
