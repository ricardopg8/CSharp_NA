using Exercise01;
using System;
using System.Globalization;



Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Dados pessoa 1:");
Console.Write("Nome: ");
p1.Nome = (Console.ReadLine());
Console.Write("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados pessoa 2:");
Console.Write("Nome: ");
p2.Nome = (Console.ReadLine());
Console.Write("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());


if (p1.Idade > p2.Idade) {
    Console.WriteLine("A pessoa mais velha e " + p1.Nome);
} 
else {
    Console.WriteLine("A pessoa mais velha e " + p2.Nome);
}

   