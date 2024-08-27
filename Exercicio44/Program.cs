/*
 44) O programa acima vai ter um problema quando digitarmos o primeiro valor
maior que o último. Resolva esse problema com um código que funcione em qualquer
situação.
 */

int primeiroValor = 1000, segundoValor = 1, incremento;

while (primeiroValor > segundoValor)
{
    Console.WriteLine("Digite o primeiro valor: ");
    primeiroValor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    segundoValor = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Digite o incremento: ");
incremento = Convert.ToInt32(Console.ReadLine());

while (primeiroValor <= segundoValor)
{
    Console.Write(primeiroValor + " ");

    primeiroValor += incremento;

}
Console.Write("Acabou!");
