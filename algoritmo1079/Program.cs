﻿using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
      
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            
            string[] valores = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

           
            double mediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

           
            Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

