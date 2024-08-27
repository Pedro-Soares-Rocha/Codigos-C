/*
 * 31) Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)
 */

string jogada, jogada2;

Console.WriteLine("Digite sua jogada: Pedra, Papel ou Tesoura");
jogada = Console.ReadLine();

Console.WriteLine("Digite sua jogada: Pedra, Papel ou Tesoura");
jogada2 = Console.ReadLine();

int jogadorVencedor = 0;

if(jogada == jogada2)
{
    Console.WriteLine("Houve um empate");
    return;
}

if(jogada.ToLower() == "pedra" )
{
    if(jogada2.ToLower() == "tesoura")
        {
        jogadorVencedor = 1;
        }
    else
    {
        jogadorVencedor = 2;
    }
}

else if (jogada.ToLower() == "papel")
{
    if (jogada2.ToLower() == "pedra")
    {
        jogadorVencedor = 1;
    }
    else
    {
        jogadorVencedor = 2;
    }
}
else if(jogada.ToLower() == "tesoura")
{
    if (jogada2.ToLower() == "papel")
    {
        jogadorVencedor = 1;
    }
    else
    {
        jogadorVencedor = 2;
    }
}

if (jogadorVencedor == 1)
{
    Console.WriteLine("Jogador 1 " + jogada + " ganha de Jogador 2 "
+ jogada2);
} 
else
{
    Console.WriteLine("Jogador 1 " + jogada + " perde de Jogador 2 "
         + jogada2);
}
