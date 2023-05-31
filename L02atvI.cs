/*i) Escreva um programa que peça ao usuário para digitar dois números e exiba
o resultado da multiplicação entre eles.*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2, mu;
    Console.Write("Por favor digite o 1º número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
     Console.Write("Por favor digite o 2º número: ");
    n2= Convert.ToDouble(Console.ReadLine());
   mu = n1 * n2;
    Console.Write("A multiplicação entre {0} e {1} é igual a {2}.", n1,n2,mu);
  }
}