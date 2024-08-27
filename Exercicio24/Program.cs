int distancia;
decimal valorTotal;

Console.WriteLine("Digite a distância a percorer: ");
distancia = Convert.ToInt32(Console.ReadLine());

if (distancia <= 200)
{
    valorTotal = distancia * 0.50M;
}
else
{
    valorTotal = distancia * 0.45M;
}

Console.WriteLine("O valor total a pagar é de: R$" + valorTotal);
