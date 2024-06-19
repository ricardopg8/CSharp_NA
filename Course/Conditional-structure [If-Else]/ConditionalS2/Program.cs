// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a hora?");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia");
            } 
            else if ((hora >= 12) && (hora < 18)) {
                Console.WriteLine("Boa tarde");
            }
            else { Console.WriteLine("Boa noite");
            }
        }
    }
}
