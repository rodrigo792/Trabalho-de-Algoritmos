
using System;

class Programa
{
    static void Main(string[] args)
    {
        // Ler a quantidade de valores N
        int n = int.Parse(Console.ReadLine());

        // Processar cada valor
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (x % 2 == 0) 
            {
                if (x > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }
            else 
            {
                if (x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}


