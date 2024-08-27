/*
 32) Escreva um programa para aprovar ou não o empréstimo bancário para a compra
de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e
em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que
ela não pode exceder 30% do salário ou então o empréstimo será negado.
 */

decimal valorCasa, salarioComprador, valorMensalCasa, limiteComprometimentoSalario;
int anosAPagar;


Console.WriteLine("Digite o valor da casa: ");
valorCasa = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o salario do comprador: ");
salarioComprador = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o prazo (em anos) para o pagamento: ");
anosAPagar = Convert.ToInt32(Console.ReadLine());

valorMensalCasa = (valorCasa / anosAPagar) / 12;
limiteComprometimentoSalario = salarioComprador * 0.3M;

if(limiteComprometimentoSalario > valorMensalCasa)
{
    Console.WriteLine("Compra aprovada");
}
else
{
    Console.WriteLine("Compra negada");
}





