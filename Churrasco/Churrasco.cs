Console.WriteLine("-- Churrasco ---");
Console.Write("Adultos (que consomem bebida alcoólicas): ");
decimal ab = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Adultos (que não consomem bebida alcoólicas): ");
decimal an = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Crianças: ");
decimal c = Convert.ToDecimal(Console.ReadLine()!);

decimal carne = (ab * 0.4m) + (an * 0.4m) + (c * 0.2m);
Console.WriteLine($"Carne: {carne}kg");
decimal acomp = (ab * 0.2m) + (an * 0.2m) + (c * 0.2m);
Console.WriteLine($"Acompanhamentos: {acomp}kg");
decimal cerveja = (ab * 2m);
Console.WriteLine($"Cerveja: {cerveja}l");
decimal refri = (an * 0.5m) + (c * 0.5m);
Console.WriteLine($"Refrigerante: {refri}l");
decimal agua = (ab * 0.4m) + (an * 0.4m) + (c * 0.4m);
Console.WriteLine($"Água: {agua}l");



