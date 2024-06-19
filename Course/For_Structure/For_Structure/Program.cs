// See https://aka.ms/new-console-template for more information

// For é mais utilizado, quando você conhece a quantidade de repetições que serão executadas.
// Para indefinidas quantidades de repetições, utilzar a estrutura [While]

using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(String[] args) {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.Write("Valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
                   
            }

            Console.WriteLine("Soma = " + soma);
            
        }
    }
}