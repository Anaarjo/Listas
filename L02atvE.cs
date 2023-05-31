/*e) Escreva um programa que peça ao usuário para digitar
dois números e exiba 
o resultado da divisão do primeiro pelo segundo.*/
using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2, div;
    Console.Write("Por favor digite o 1º número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
     Console.Write("Por favor digite o 2º número: ");
    n2= Convert.ToDouble(Console.ReadLine());
    div = n1 / n2;
    Console.WriteLine("O número {0} divido por {1} é igual a {2} .", n1, n2, div);
  }
}