/*Escreva um programa que peça ao usuário para digitar dois números e exiba 
a soma deles.*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2 , soma;
    Console.Write ("Por favor, digite o primeiro número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.Write ("Por favor, digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());
    soma = n1 + n2;
    Console.WriteLine("A soma de {0} + {1} é igual a {2}.", n1,n2,soma);

    
  }
}