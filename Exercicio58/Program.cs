/*
 58) Crie um programa que leia o sexo e a idade de várias pessoas. O programa vai
perguntar se o usuário quer continuar ou não a cada pessoa.
No final, mostre:
a) qual é a maior idade lida
b) quantos homens foram cadastrados
c) qual é a idade da mulher mais jovem
d) qual é a média de idade entre os homens
 */

int idade, maiorIdade = 0, qtdDeHomens = 0, idadeMulherMaisJovem = 0, totalIdadeHomens = 0;
string continuar = "s", sexo;
while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu sexo (M ou F): ");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > maiorIdade)
    {
        maiorIdade = idade;
    }

    if(sexo.ToUpper() == "M")
    {
        qtdDeHomens++;
        totalIdadeHomens += idade;
    }
    else
    {
        if(idade> idadeMulherMaisJovem)
        {
            idade = idadeMulherMaisJovem;
        }
    }
    
    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}

Console.WriteLine("Qual é a maior idade lida: " + maiorIdade);
Console.WriteLine("Quantos homens foram cadastrados: " + qtdDeHomens);
Console.WriteLine("Qual é a idade da mulher mais jovem: " + idadeMulherMaisJovem);
Console.WriteLine("Qual é a média de idade entre os homens: " + (totalIdadeHomens/qtdDeHomens));