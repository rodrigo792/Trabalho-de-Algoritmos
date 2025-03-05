
using System;

class Program
{
    
    static bool EhPrimo(int x)
    {
        if (x <= 1) return false;
        if (x == 2) return true; 
        if (x % 2 == 0) return false; 

        
        for (int i = 3; i * i <= x; i += 2)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

   
            if (EhPrimo(X))
            {
                Console.WriteLine($"{X} eh primo");
            }
            else
            {
                Console.WriteLine($"{X} nao eh primo");
            }
        }
    }
}
