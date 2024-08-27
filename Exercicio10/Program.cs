
decimal largura, altura, areaTotal;
int tamanhoAreaPintadaLt = 2;

Console.WriteLine("Qual a largura de sua parede: ");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual a altura de sua parede: ");
altura = Convert.ToDecimal(Console.ReadLine());

areaTotal = largura * altura;

Console.WriteLine("Serão necessarios: " + 
    (areaTotal / tamanhoAreaPintadaLt) + " litros de tinta");