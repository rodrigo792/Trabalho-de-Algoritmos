
using System;

class Program
{
    static void Main()
    {
        // Lê o valor de X
        int X = int.Parse(Console.ReadLine());
        int Z;

        // Lê o valor de Z até que seja maior que X
        while (true)
        {
            Z = int.Parse(Console.ReadLine());
            if (Z > X)
                break;
        }

        // Variáveis para calcular a soma
        int count = 0;
        int sum = 0;

        // Soma os números a partir de X até ultrapassar Z
        for (int i = X; sum <= Z; i++)
        {
            sum += i;
            count++;
        }

        // Imprime a quantidade de números somados
        Console.WriteLine(count);
    }
}

