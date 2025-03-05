
using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i += 2) 
        {
            int jInicio = i + 6; 
            for (int j = jInicio; j >= jInicio - 2; j--) 
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}

