// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace CAM_Ex02 {
    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.Write("Nome.: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto.: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto.: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em qual porcentagem? ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(percent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
           
        }
    }
}