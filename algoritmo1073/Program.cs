
using System;

class Programa
{
    static void Main(string[] args)
    {
       
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 2; i <= n; i += 2) 
        {
            int quadrado = i * i;
            Console.WriteLine($"{i}^2 = {quadrado}");
        }
    }
}

