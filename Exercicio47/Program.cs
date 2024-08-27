/*
 47) Faça um programa que leia 7 números inteiros e no final mostre o somatório
entre eles.
 */

int contador = 0, numero, somatorio = 0;

while(contador < 7)
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    somatorio += numero;
    contador++;

}

Console.WriteLine("O valor final foi: " + somatorio);