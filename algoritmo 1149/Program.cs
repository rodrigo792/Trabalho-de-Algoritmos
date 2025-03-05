using System;

class Program
{
    static void Main()
    {
        // Lê os valores A e N
        string[] inputs = Console.ReadLine().Split();
        int A = int.Parse(inputs[0]);
        int N = int.Parse(inputs[1]);

        // Se N for menor ou igual a zero, continua pedindo o valor de N
        while (N <= 0)
        {
            N = int.Parse(Console.ReadLine());
        }

        // Soma os valores de A + i para cada i de 0 até N-1
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += A + i;
        }

        
        Console.WriteLine(sum);
    }
}

