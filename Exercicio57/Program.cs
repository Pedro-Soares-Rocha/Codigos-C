/*
 57) Faça um algoritmo que leia a idade de vários alunos de uma turma. O programa
vai parar quando for digitada a idade 999. No final, mostre quantos alunos existem na turma
e qual é a média de idade do grupo.
 */

int idade = 0, totalIdades = 0, qtdDeAlunos = 0;

while (idade != 999)
{
    totalIdades += idade;
    qtdDeAlunos++;

    Console.WriteLine("Digite sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("O total de alunos é de: " + qtdDeAlunos);
Console.WriteLine("A média de idades na turma é de: " + (totalIdades/qtdDeAlunos));