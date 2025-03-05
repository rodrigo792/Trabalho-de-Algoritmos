
using System;

class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());

      
        long a = 0, b = 1;

       
        for (int i = 0; i < N; i++)
        {
            
            Console.Write(a);

            if (i < N - 1)
                Console.Write(" ");

           
            long temp = a;
            a = b;
            b = temp + b;
        }

       
        Console.WriteLine();
    }
}
