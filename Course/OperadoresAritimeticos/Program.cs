﻿using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            int n1 = 3 + 4 * 2;
            int n2 = ( 3 + 4 ) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; // ou float
            double n5 = 10.0 / 8; // Pelo menos um deles tem que ter o ".0"

            double a = 1.0, b = -3.0, c = -4.0;
           // double delta = b * b - 4.0 * a * c; // Delta de Bascara
            double deltamath = Math.Pow(b, 2.0) - 4.0 * a * c; // Função Math

            double x1 = (-b + Math.Sqrt(deltamath)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(deltamath)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(deltamath);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}