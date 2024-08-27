/*
33) O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no
peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o
indivíduo dentro de certas faixas.
- abaixo de 18.5: Abaixo do peso
- entre 18.5 e 25: Peso ideal
- entre 25 e 30: Sobrepeso
- entre 30 e 40: Obesidade
- acima de 40: Obseidade mórbida
Obs: O IMC é calculado pela expressão peso/altura2 (peso dividido pelo quadrado
da altura)
 */

decimal peso, altura, imc;

Console.WriteLine("Digite seu peso: ");
peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
altura = Convert.ToDecimal(Console.ReadLine());

imc = peso / (altura * altura);

if (imc < 18.50M)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc <25)
{
    Console.WriteLine("Peso ideal");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (imc < 40)
{
    Console.WriteLine("Obseidade");
}
else
{
    Console.WriteLine("Obseidade mórbida");
}

