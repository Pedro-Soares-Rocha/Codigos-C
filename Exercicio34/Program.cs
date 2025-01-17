﻿/*
 34) Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O
aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para
carro de luxo. Além disso, o cliente paga por Km percorrido. Faça um programa
que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e
quantos Km foram percorridos. No final mostre o preço a ser pago de acordo com a
tabela a seguir:
- Carros populares (aluguel de R$90 por dia)
- Até 100Km percorridos: R$0,20 por Km
- Acima de 100Km percorridos: R$0,10 por Km
- Carros de luxo (aluguel de R$150 por dia)
- Até 200Km percorridos: R$0,30 por Km
- Acima de 200Km percorridos: R$0,25 por Km
 */

string tipoCarro;
int quantidadeDias, kmPercorridos = 0;
decimal valorCobranca = 0;

Console.WriteLine("Digite o tipo de carro (popular ou luxo): ");
tipoCarro = Console.ReadLine();

Console.WriteLine("Digite a quantidade de dias do aluguel: ");
quantidadeDias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os kms percorridos: ");
quantidadeDias = Convert.ToInt32(Console.ReadLine());

if(tipoCarro == "popular")
{
    valorCobranca = 90 * quantidadeDias;
    if(kmPercorridos <=100)
    {
        valorCobranca += 0.20M * kmPercorridos;
    }
    else
    {
        valorCobranca += 0.10M * kmPercorridos;
    }
}
else
{
    valorCobranca = 150 * quantidadeDias;
    if (kmPercorridos <= 200)
    {
        valorCobranca += 0.30M * kmPercorridos;
    }
    else
    {
        valorCobranca += 0.25M * kmPercorridos;
    }
}

Console.WriteLine("O total do aluguel foi de: " + valorCobranca);