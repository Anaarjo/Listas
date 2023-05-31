/*b) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu dobro.*/

using System;

class Program {
  public static void Main (string[] args) {
    double n1, dobro;
    Console.Write("Por favor, digite um número : ");
    n1 = Convert.ToDouble(Console.ReadLine());
    dobro = n1 * 2;
    Console.WriteLine("O dobro de {0} é igual a {1} .", n1, dobro);
  }
}