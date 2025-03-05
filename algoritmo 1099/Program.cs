using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

       
        for (int i = 0; i < N; i++)
        {
            
            string[] inputs = Console.ReadLine().Split();
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            
            if (X > Y)
            {
                int temp = X;
                X = Y;
                Y = temp;
            }

            
            int sum = 0;
            for (int j = X + 1; j < Y; j++)
            {
                if (j % 2 != 0)  
                {
                    sum += j;
                }
            }

          
            Console.WriteLine(sum);
        }
    }
}


