// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

double xA, xB, xC, yA, yB, yC;


Console.WriteLine("Entre com as medidas do triângulo X:");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com as medidas do triângulo Y:");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areax = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areay = Math.Sqrt(p * (p - yA) * (p - yB) * (p -yC));

Console.WriteLine("Área de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

if (areax > areay) {
    Console.WriteLine("Maior área é X.");
}
else {
    Console.WriteLine("Maior área é Y.");
}