decimal valorReal, valorDolar , cambioDolar = 5.56M;

Console.WriteLine("Digite quantos reais você tem: ");
valorReal= Convert.ToDecimal(Console.ReadLine());

valorDolar = valorReal / cambioDolar;

Console.WriteLine("Você pode comprar $ " + valorDolar);
