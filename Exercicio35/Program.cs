/*
 35) Um programa de vida saudável quer dar pontos atividades físicas que podem
ser trocados por dinheiro. O sistema funciona assim:
- Cada hora de atividade física no mês vale pontos
- até 10h de atividade no mês: ganha 2 pontos por hora
- de 10h até 20h de atividade no mês: ganha 5 pontos por hora
- acima de 20h de atividade no mês: ganha 10 pontos por hora
- A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
 */

int horasAtividadeMes, pontos = 0;
decimal valorFinal;

Console.WriteLine("Digite a quantidade de horas em atividades fisicas no mês: ");
horasAtividadeMes = Convert.ToInt32(Console.ReadLine());

if (horasAtividadeMes <= 10)
{
    pontos = 2 * horasAtividadeMes;
}
else if (horasAtividadeMes <= 20)
{
    pontos = 5 * horasAtividadeMes;
}
else
{
    pontos = 10 * horasAtividadeMes;
}

valorFinal = pontos * 0.05M;

Console.WriteLine("O valor do premio é de: R$" + valorFinal);

