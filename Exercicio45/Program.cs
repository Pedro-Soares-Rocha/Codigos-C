/*
 45) Crie um programa que calcule e mostre na tela o resultado da soma entre 6 +
8 + 10 + 12 + 14 + ... + 98 + 100.
 */

int contador = 6, resultado = 0;

while (contador <= 100)
{
    resultado += contador;

    contador += 2;
}

Console.WriteLine("O resultado final foi de: " + resultado);