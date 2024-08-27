int numero;

Console.WriteLine("Digite seu numero: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O antecessor do seu numero (" + numero + ") é " + (numero - 1));
Console.WriteLine("O sucessor do seu numero (" + numero + ") é " + (numero + 1));