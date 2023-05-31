/*h) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu valor absoluto.*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2, sub;
    Console.Write("Por favor digite o 1º número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
     Console.Write("Por favor digite o 2º número: ");
    sub = n2 - n1;
    Console.WriteLine("O número {0} subtraído por {1} é igual a {2} .", n2, n1, sub);
  }
}