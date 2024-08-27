string nome;
decimal salario;

Console.WriteLine("Nome do funcionario:");
nome = Console.ReadLine();  

Console.WriteLine("Salário: ");
string salarioStr = Console.ReadLine();

salario = Convert.ToDecimal(salarioStr);

Console.WriteLine("O funcionário " + nome + " tem um saláro de: R$" + salario + " em Agosto");
