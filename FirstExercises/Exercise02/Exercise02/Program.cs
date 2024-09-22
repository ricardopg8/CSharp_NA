
using Exercise02;
using System.Globalization;

/*
EXERCÍCIO 02:
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.

Exemplo:
Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00

Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00
Salário médio = 6500.00
*/

FuncSalario f1 = new FuncSalario();
FuncSalario f2 = new FuncSalario();

Console.WriteLine("Nome Funcionario Um: ");
Console.Write("Nome: ");
f1.Nome =  Console.ReadLine();
Console.Write("Salario: ");
f1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados Funcionario Dois: ");
Console.Write("Nome: ");
f2.Nome = Console.ReadLine();
Console.Write("Salario: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double media = (f1.Salario + f2.Salario) / 2;

Console.WriteLine("A Media dos salarios dos Funcionarios Um e Dois e: " + media.ToString("F2", CultureInfo.InvariantCulture));


