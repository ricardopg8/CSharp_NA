﻿using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o valor");

        int x = int.Parse(Console.ReadLine());

        if (x % 2 == 0) {
            Console.WriteLine("Par");

        }   
        else {
            Console.WriteLine("Impar");
                }
            }
    }