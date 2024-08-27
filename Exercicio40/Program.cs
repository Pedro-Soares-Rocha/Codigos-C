/*
 40) Desenvolva um programa que mostre na tela a seguinte contagem:
100 95 90 85 80 ... 0 Acabou!
 */

int contador = 100;

while (contador >= 0)
{
    Console.Write(contador + " ");
    contador -= 5;
}

Console.Write("Acabou!");