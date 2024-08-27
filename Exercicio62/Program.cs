/*
 62) Escreva um programa que leia um número qualquer e mostre a tabuada desse
número, usando a estrutura “para”.
Ex: Digite um valor: 5
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15 ...
 */

int mutiplicando;

Console.WriteLine("Digite um número da tabuada: ");
mutiplicando = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(mutiplicando + " x " + i + " = " + (mutiplicando * i));
}
