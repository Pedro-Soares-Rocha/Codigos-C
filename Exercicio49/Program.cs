/*
 50) Desenvolva um programa que faça o sorteio de 20 números entre 0 e 10 e
mostre na tela:
a) Quais foram os números sorteados
b) Quantos números estão acima de 5
c) Quantos números são divisíveis por 3
 */

int contador = 0, quantidadeAcima5 = 0, quantidadeDivisivel3= 0, numero;
string numerosSorteados = "";

Random rand = new Random();

while(contador <20)
{
    numero = rand.Next(0, 10);

    numerosSorteados += numero + " ";

    if(numero >  5)
    {
        quantidadeAcima5++;
    }

    if(numero % 3 == 0)
    {
        quantidadeDivisivel3++;
    }
    
    contador++;
}

Console.WriteLine(numerosSorteados + " foram sorteados");
Console.WriteLine(quantidadeAcima5 + " números estão acima de 5");
Console.WriteLine(quantidadeDivisivel3 + " números são divisiveis por 3");