/*
 53) Faça um programa que leia a idade e o sexo de 5 pessoas, mostrando no final:
a) Quantos homens foram cadastrados
b) Quantas mulheres foram cadastradas
c) A média de idade do grupo
d) A média de idade dos homens
e) Quantas mulheres tem mais de 20 anos
 */

int contador = 0, idade, qtdMulheres = 0, qtdHomens = 0, mediaIdade = 0,
    mediaIdadeHomens = 0, qtdMulheresMais20 = 0;
string sexo = "";

while(contador < 5)
{
    Console.WriteLine("Digite a sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite seu sexo: ");
    sexo = Console.ReadLine();

    if(sexo.ToUpper() =="F")
    {
        qtdMulheres++;
        
        if(idade > 20)
        {
            qtdMulheresMais20++;
        }
    }
    else
    {
        qtdHomens++;
        mediaIdadeHomens += idade;
    }

    mediaIdade += idade;

    contador++;
}

Console.WriteLine("Foram cadastrados: " + qtdHomens + " homens");
Console.WriteLine("Foram cadastrados: " + qtdMulheres + " mulheres");
Console.WriteLine("A média de idade do grupo: " + (mediaIdade /5));
Console.WriteLine("A média de idade dos homens: " + (mediaIdadeHomens/qtdHomens));
Console.WriteLine("Mulheres acima de 20: " + qtdMulheresMais20);