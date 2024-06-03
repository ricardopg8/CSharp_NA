// See https://aka.ms/new-console-template for more information


using System;

namespace Course {
    class OperadoresAtribuicao {
        static void Main(string[] args) {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            // += com string concatena;'ao cumulativa de strings

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            // ++ e --

            int a2 = 10;
            a2++;
            Console.WriteLine(a2);

            // --

            int s2 = 10;
           // int a3 = s2++;
            int bb = ++s2;


            Console.WriteLine(s2);
            //Console.Write(a3);
            Console.WriteLine(bb);
        }
    }
}