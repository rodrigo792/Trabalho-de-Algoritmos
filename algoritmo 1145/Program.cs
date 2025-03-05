
using System;

class Program
{
    static void Main()
    {
        
        string[] inputs = Console.ReadLine().Split();
        int X = int.Parse(inputs[0]);
        int Y = int.Parse(inputs[1]);

        
        int count = 0;

        
        for (int i = 1; i <= Y; i++)
        {
            
            Console.Write(i);

            
            count++;

            
            if (count == X)
            {
                Console.WriteLine();  
                count = 0;            
            }
            else
            {
                Console.Write(" ");  
            }
        }

        
        if (count > 0)
        {
            Console.WriteLine();
        }
    }
}

