/*h) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu valor absoluto.*/


using System;

class Program {
  public static void Main (string[] args) {
    double n1, absoluto;
    Console.Write("Por favor digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    absoluto = Math.Abs(n1);
    Console.WriteLine("O valor absoluto de {0} é igual a {1}.", n1, absoluto);
  }
}