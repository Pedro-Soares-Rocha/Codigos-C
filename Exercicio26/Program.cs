using System;

int primeiroValor, segundoValor;

Console.WriteLine("Digite o primeiro numero: ");
primeiroValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
segundoValor = Convert.ToInt32(Console.ReadLine());

if (primeiroValor > segundoValor)    
{
     Console.WriteLine("Primeiro valor é maior");
}
else if (primeiroValor < segundoValor)
 {
     Console.WriteLine("Segundo valor é maior");
 } 
else
{
        Console.WriteLine("Não existe valor maior, ambos são iguais");
 }
