// See https://aka.ms/new-console-template for more information

using InterfaceConceito.models;
using InterfaceConceito.Interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 7));
