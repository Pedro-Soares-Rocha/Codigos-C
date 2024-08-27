

int anosFumando, quantidadeCigarrosDia, totalDiasPerdidos;

Console.WriteLine("Digite a quantidade de cigarros fumados por dia: ");
quantidadeCigarrosDia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantos anos você fuma: ");
anosFumando = Convert.ToInt32(Console.ReadLine());

totalDiasPerdidos = (((anosFumando * 365) * quantidadeCigarrosDia) * 10) / 1440;
Console.WriteLine("Você perdeu " + totalDiasPerdidos + " dias da sua vida.");
