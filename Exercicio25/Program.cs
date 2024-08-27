decimal a, b, c;

Console.WriteLine("Digite o o tamanho do lado A: ");
a = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o o tamanho do lado B: ");
b = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o o tamanho do lado C: ");
c = Convert.ToDecimal(Console.ReadLine());

if ((a + b) > c && 
    (a + c) > b && 
    (b + c) > a )
{
    Console.WriteLine("Seu triangulo é funcional");
}
else
{
    Console.WriteLine("Seu triangulo não é funcional");
}