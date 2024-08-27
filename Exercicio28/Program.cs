decimal largura, comprimento, areaTotal;

Console.WriteLine("Digite a largura do terreno: ");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terreno: ");
comprimento = Convert.ToDecimal(Console.ReadLine());

areaTotal = largura * comprimento;
string mensagem = "Área total: " + areaTotal +
    ". \nClassificação: ";
if (areaTotal < 100)
{
    Console.WriteLine(mensagem + "TERRENO POPULAR");
}
else if(areaTotal<=500)
{
    Console.WriteLine(mensagem + "TERRENO MASTER");
}
else
{
    Console.WriteLine(mensagem + "TERRENO VIP");
}
