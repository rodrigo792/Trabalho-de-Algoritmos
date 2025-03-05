
using System;

class Program
{
    static void Main(string[] args)
    {
       
        int N = int.Parse(Console.ReadLine());

        
        int[] fibonacci = new int[N];

      
        for (int i = 0; i < N; i++)
        {
            if (i == 0)
                fibonacci[i] = 0;
            else if (i == 1)
                fibonacci[i] = 1;
            else
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

       
        Console.WriteLine(string.Join(" ", fibonacci));
    }
}
