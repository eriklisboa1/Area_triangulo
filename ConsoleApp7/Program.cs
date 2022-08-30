﻿using System;
using System.Globalization;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areaX = x.Area();

            
            double areaY = y.Area();

            Console.WriteLine($"Area do triangulo X = {areaX:F4}");
            Console.WriteLine($"Area do triangulo Y = {areaY:F4}");
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area : X");
            }
            else
            {
                Console.WriteLine("Maior area : Y");
            }


        }
    }
}
