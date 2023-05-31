
/*
c) Escreva um programa que peça ao usuário para digitar um número e exiba a
sua metade.
*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1, metade;
    Console.Write("Por favor, digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    metade = n1 / 2;
    Console.WriteLine("A metade de {0} é igual a {1} .", n1, metade);
  }
}