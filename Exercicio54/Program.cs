/*
 54) Desenvolva um aplicativo que leia o peso e a altura de 7 pessoas, mostrando
no final:
a) Qual foi a média de altura do grupo
b) Quantas pessoas pesam mais de 90Kg
c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
 */

decimal peso, somaAlturas = 0, qtdMais90Kg = 0, qtdMenos50KgMenos_60m = 0,
    qtdMais1_90mMais100Kg = 0, contador = 0;
int altura = 0;

while(contador < 7)
{
    Console.WriteLine("Digite seu peso: ");
    peso = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite sua altura (cm): ");
    altura = Convert.ToInt32(Console.ReadLine());

    somaAlturas += altura;

    if(peso > 90)
    {
        qtdMais90Kg++;
    }

    if(peso < 50 && altura < 160)
    {
        qtdMenos50KgMenos_60m++;
    }

    if (peso > 100 && altura > 190)
    {
        qtdMais1_90mMais100Kg++;
    }
    contador++;
}
Console.WriteLine("A média de altura do grupo é: " + (somaAlturas / 7));
Console.WriteLine("A quantidade de pessoas que pesam mais que 90kg é : " + qtdMais90Kg);
Console.WriteLine("A quantidade de pessoas que pesam menos de 50Kg tem menos de 1.60m: " + qtdMenos50KgMenos_60m);
Console.WriteLine("A quantidade de pessoas que medem mais de 1.90m pesam mais de 100Kg: " + qtdMais1_90mMais100Kg);