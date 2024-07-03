// See https://aka.ms/new-console-template for more information
using Chapter_04;
using System;
using System.Globalization;

Triangulo x, y;
y = new Triangulo();
x = new Triangulo();


Console.WriteLine("Entre com as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  
Console.WriteLine("Entre com as medidas do triângulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Abaixo é antes do acoplamento da função dentro da Classe Triangulo.:
//double p = (xA + xB + xC) / 2.0;
//double areax = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

//Abaixo o Acomplamento da função acima na classe Triangulo.:
double areaX = x.Area();

//Abaixo é antes do acoplamento da função dentro da Classe Triangulo.:
//p = (yA + yB + yC) / 2.0;
//double areay = Math.Sqrt(p * (p - yA) * (p - yB) * (p -yC));

//Abaixo o Acomplamento da função acima na classe Triangulo.:
double areaY = y.Area();

Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY) {
    Console.WriteLine("Maior área é X.");
}
else {
    Console.WriteLine("Maior área é Y.");
}