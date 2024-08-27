int totalKm, totalDias;
decimal valorDia = 90, valorKmRodado = 0.20M, valorTotal;

Console.WriteLine("Digite a quantidade de dias que ficou com o carro: ");
totalDias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de kms rodado: ");
totalKm = Convert.ToInt32(Console.ReadLine());

valorTotal = (totalDias * valorDia) + (totalKm * valorKmRodado);

Console.WriteLine("O valor total da fatura é de: R$: " + valorTotal);
