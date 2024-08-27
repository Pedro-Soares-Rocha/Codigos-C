/*
 56) Desenvolva um aplicativo que leia o salário e o sexo de vários funcionários.
No final, mostre o total de salários pagos aos homens e o total pago às mulheres. O
programa vai perguntar ao usuário se ele quer continuar ou não sempre que ler os dados de
um funcionário.
 */

decimal salario, totalSalarioHomens = 0, totalSalarioMulheres = 0;
string sexo, continuar = "s";

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu sexo (F ou M):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite seu salário:");
    salario = Convert.ToDecimal(Console.ReadLine());

    if(sexo.ToUpper() == "M")
    {
        totalSalarioHomens += salario;
    }
    else
    {
        totalSalarioMulheres += salario;
    }

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}

Console.WriteLine("Total salario dos homens: " + totalSalarioHomens);
Console.WriteLine("Total salario das mulheres: " + totalSalarioMulheres);