/*j) Escreva um programa que peça ao usuário para digitar um número e exiba o
seu resto da divisão por 2.*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1;
    Console.Write("Digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("O resto da divisão é igual a "
      + n1 % 2);
    }
}