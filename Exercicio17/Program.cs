


int velocidadeCarro, limiteVelocidade = 80;
decimal valorMulta = 5, valorPagar;

Console.WriteLine("Digite a velocidade do carro: ");
velocidadeCarro = Convert.ToInt32(Console.ReadLine());

if(velocidadeCarro>limiteVelocidade)
{
    valorPagar = (velocidadeCarro - limiteVelocidade) * valorMulta;
    Console.WriteLine("Você passou acima do limite permitido, multa de: R$" + valorPagar);
}