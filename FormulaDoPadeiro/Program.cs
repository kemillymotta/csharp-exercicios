Console.WriteLine("--- Padaria ---");
Console.WriteLine();

Console.Write("Peso desejado de pão italiano (em gramas): ");
decimal peso = Convert.ToDecimal(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("Ingredientes:");

decimal farinha = (peso / 2.12m) / 1000;
Console.WriteLine($"Farinha: {farinha:N3}g");

decimal agua = farinha * 0.7m;
Console.WriteLine($"Água: {agua:N3}g");

decimal fermento = farinha * 0.4m;
Console.WriteLine($"Fermento: {fermento:N3}g");

decimal sal = farinha * 0.02m;
Console.WriteLine($"Sal: {sal:N3}g");
