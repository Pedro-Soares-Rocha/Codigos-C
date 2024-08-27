/*
 36) Uma empresa precisa reajustar o salário dos seus funcionários, dando um aumento de
acordo com alguns fatores. Faça um programa que leia o salário atual, o gênero do
funcionário e há quantos anos esse funcionário trabalha na empresa.
No final, mostre o seu novo salário, baseado na tabela a seguir:
- Mulheres
- menos de 15 anos de empresa: +5%
- de 15 até 20 anos de empresa: +12%
- mais de 20 anos de empresa: +23%
- Homens
- menos de 20 anos de empresa: +3%
- de 20 até 30 anos de empresa: +13%
- mais de 30 anos de empresa: +25%
 */

int quantidadeAnos;
decimal salarioAtual, salarioFinal;
string genero;

Console.WriteLine("Digite o gênero do funcionário");
genero = Console.ReadLine();

Console.WriteLine("Digite a quantos anos ele trabalha na empresa");
quantidadeAnos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o salário do funcionário");
salarioAtual = Convert.ToDecimal(Console.ReadLine());

if (genero.ToUpper() == "M")
{
    if (quantidadeAnos < 15)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.05M);
    }
    else if (quantidadeAnos > 20)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.12M);
    }
    else
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.23M);
    }
}
else
{
    if (quantidadeAnos < 20)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.053M);
    }
    else if (quantidadeAnos > 30)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.13M);
    }
    else
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.25M);
    }
}

Console.WriteLine("O novo salario do funcionario é igual a: R$" +  salarioFinal);