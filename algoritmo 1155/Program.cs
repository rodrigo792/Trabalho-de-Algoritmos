﻿
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double S = 0.0;

     
        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i; 
        }

        
        Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
    }
}
