
using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < N; i++)
        {
            // Lê os valores de X e Y
            string[] inputs = Console.ReadLine().Split();
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            // Se X for par, começa no próximo número ímpar
            if (X % 2 == 0)
            {
                X++; 
            }

            // Soma os Y ímpares consecutivos
            int sum = 0;
            for (int j = 0; j < Y; j++)
            {
                sum += X;
                X += 2; 
            }

            
            Console.WriteLine(sum);
        }
    }
}
