/*
 39) Crie um aplicativo que mostre na tela a seguinte contagem:
0 3 6 9 12 15 18 Acabou!
 */

int contador = 0;

while(contador <= 18)
{
    Console.Write(contador + " ");

    contador += 3;
}

Console.Write("Acabou!");