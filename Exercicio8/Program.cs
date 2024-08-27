decimal km, hm, dam, dm, cm, mm, metros;

Console.WriteLine("Digite a quantidade de metros: ");
metros = Convert.ToDecimal(Console.ReadLine());

km = metros * 0.001M;
hm = metros * 0.01M;
dam = metros * 0.1M;
dm = metros * 10;
cm = metros * 100;
mm = metros * 1000;

Console.WriteLine("O valor de metros em km é: " + km);
Console.WriteLine("O valor de metros em hm é: " + hm);
Console.WriteLine("O valor de metros em dam é: " + dam);
Console.WriteLine("O valor de metros em dm é: " + dm);
Console.WriteLine("O valor de metros em cm é: " + cm);
Console.WriteLine("O valor de metros em mm é: " + mm);

