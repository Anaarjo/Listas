/*f) Escreva um programa que peça ao usuário para digitar um número e exiba a
sua raiz quadrada.*/

using System;

class Program {
  public static void Main (string[] args) {
    double n1, raiz;
    Console.Write("Por favor digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    raiz = Math.Sqrt(n1);
    Console.WriteLine("A raiz quadrada de {0} é igual a {1}.", n1, raiz);
  }
}