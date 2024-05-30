

using System; // SByte É um tipo de DotNet, então né necessário passar no inicio/topo do código o "using System;"

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';    // char com unicode
            sbyte x = 127;
            SByte y = 127;
            byte n1 = 255; //256 caso de over flow
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // Sufixo "L" indica que essa dado é do tipo Long
            float n5 = 4.5f; // Com ponto fica double, para indicar que é float, passaro "f" minusculo no final do numero.
            double n6 = 4.5;
            string nome = "Maria Green"; // Não está na tabela do CSharp. o string é imutavel por segurança e prevenção a erros.
            // Se passado logo após a váriavel nome ter recebido o valor inicial, outro valor como: nome = "João Black" não esta
            // ra sendo alterado o valor na variável nome, e sim passando uma outra (nova) variável.
            object obj1 = "Alex Brown"; // As variáveis object recebem qualquer tipo de dado, reconhecnedo-os conforme a escrita.
            object obj2 = 4.5f;

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            // fazer testes com MinValue e MaxValue


            n1++;
            x++;
            completo = true;
            completo = false;



            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);

        }
    }
}