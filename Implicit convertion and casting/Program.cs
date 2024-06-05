using System;

namespace ImplicitConvertionAndCasting {
    class Program {
        static void Main(string[] args) {
            //Conversão inplicita de tipos:
            float x = 4.5f; //4bytes

            double y = x;//8bytes
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a; //Casting
            Console.WriteLine(b);

            //----------------------------------------

            //Conversão inplicita de tipos:

            double m;
            int n;

            m = 5.1;
            n = (int)m; //Casting + 
            Console.WriteLine(n);

            int t = 5;
            int j = 2;

            double resultado = (double) t / j;
            Console.WriteLine(resultado);

        }
    }
}