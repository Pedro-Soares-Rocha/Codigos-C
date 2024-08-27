/*
 52) Crie um algoritmo que leia a idade de 10 pessoas, mostrando no final:
a) Qual é a média de idade do grupo
b) Quantas pessoas tem mais de 18 anos
c) Quantas pessoas tem menos de 5 anos
d) Qual foi a maior idade lida
 */

int idade, mediaIdadeGrupo=0, quantidadeMaior18=0, 
    quantidadeMenor5=0, maiorIdadeLida=0, contador = 0;

while (contador < 10)
{
    Console.WriteLine("Digite sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if(contador ==0 || idade > maiorIdadeLida)
    {
        maiorIdadeLida = idade;
    }

    mediaIdadeGrupo += idade;

    if(idade > 18)
    {
        quantidadeMaior18++;
    }

    if(idade > 5)
    {
        quantidadeMenor5++;
    }
   
}

Console.WriteLine("Qual é a média do grupo: " + (mediaIdadeGrupo/10));
Console.WriteLine("Quantas pessoas tem mais de 18 anos: " + quantidadeMaior18);
Console.WriteLine("Quantas pessoas tem menos de 5 anos: " + quantidadeMenor5);
Console.WriteLine("Qual é a maior idade do grupo: " + maiorIdadeLida);
