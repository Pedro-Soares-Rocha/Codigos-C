string nome, sexo;
decimal valorCompras, percentualDescontoHomem = 0.05M,
    percentualDescontoMulher = 0.13M;

Console.WriteLine("Escreva seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite seu sexo (M ou F): ");
sexo = Console.ReadLine();

Console.WriteLine("Digite o total das compras: ");
valorCompras = Convert.ToDecimal(Console.ReadLine());

if(sexo.ToUpper() == "F")
{
    Console.WriteLine("O valor do desconto é de: R$ " +
        (valorCompras * percentualDescontoMulher));

} 
else
{
    Console.WriteLine("O valor do desconto é de: R$ " +
        (valorCompras * percentualDescontoHomem));
}