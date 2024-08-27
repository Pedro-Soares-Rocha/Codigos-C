

int diasTrabalhados, horasDoDia = 8;
decimal valorHora = 25, salario;

Console.WriteLine("Digite a quantidade de dais trabalhados no mês: ");
diasTrabalhados = Convert.ToInt32(Console.ReadLine());

salario = (diasTrabalhados * horasDoDia) * valorHora;

Console.WriteLine("O salário para o mês é de: R$" + salario);

