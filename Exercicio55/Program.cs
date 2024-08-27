/*
 55) Crie um programa que leia vários números pelo teclado e mostre no final o
somatório entre eles.
Obs: O programa será interrompido quando o número 1111 for digitado
 */

int numero = 0, somatorio=0;

while(numero != 1111)
{
    Console.WriteLine("Digite um número:");
    numero = Convert.ToInt32(Console.ReadLine());

    somatorio += numero;
}

Console.WriteLine("O somatório dos números é igual a: " + somatorio);

