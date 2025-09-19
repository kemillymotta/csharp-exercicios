Console.Write("Entre com a medida (em metros): ");
decimal m = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("--- Equivalência ---");
decimal cm = m * 100m;
Console.WriteLine($"{cm} cm");
Console.WriteLine($"{m} m");
decimal km = m / 1000m;
Console.WriteLine($"{km} km");