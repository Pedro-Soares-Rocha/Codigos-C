int ano;

Console.WriteLine("Digite o ano: ");
ano = Convert.ToInt32(Console.ReadLine());

if ((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)))
{
    Console.WriteLine("O ano é bissexto.");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}