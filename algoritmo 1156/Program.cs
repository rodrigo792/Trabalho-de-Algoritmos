using System;

class Program
{
    static void Main()
    {
        double S = 0;
        double numerador = 1;
        double denominador = 1;

        
        for (int i = 0; i < 20; i++)
        {
            S += numerador / denominador;

            
            numerador += 2;
            denominador *= 2;
        }

        // Exibe o resultado com 2 casas decimais
        Console.WriteLine($"{S:F2}");
    }
}


