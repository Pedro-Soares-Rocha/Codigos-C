int numero;

Console.WriteLine("Digite seu numero: ");
numero = Convert.ToInt32(Console.ReadLine());

if(numero % 2 ==0)
{
    Console.WriteLine("Esse numero é par.");
}
else
{
    Console.WriteLine("Esse numero é impar");
}