/*d) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu quadrado.*/

using System;

class Program {
  public static void Main (string[] args) {
    double n1, quad;
    Console.Write("Por favor digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    quad = Math.sq(n1,2);
    Console.WriteLine("O número {0} ao quadrado é {1} .", n1, quad);
  }
}