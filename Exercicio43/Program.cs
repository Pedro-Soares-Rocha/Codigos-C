/*
 43) Crie um algoritmo que leia o valor inicial da contagem, o valor final e o
incremento, mostrando em seguida todos os valores no intervalo:
Ex: Digite o primeiro Valor: 3
Digite o último Valor: 10
Digite o incremento: 2
Contagem: 3 5 7 9 Acabou!
 */

int primeiroValor, segundoValor, incremento;

Console.WriteLine("Digite o primeiro valor: ");
primeiroValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
segundoValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o incremento: ");
incremento = Convert.ToInt32(Console.ReadLine());

while ( primeiroValor <= segundoValor)
{
    Console.Write(primeiroValor+ " ");

    primeiroValor += incremento;

}
Console.Write("Acabou!");
