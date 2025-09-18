Console.WriteLine("--- Ginástica Artística ---");

Console.Write("Ginasta: ");
String g = Console.ReadLine();
Console.Write("Nota de Partida: ");
decimal p = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Nota de Execução: ");
decimal e = Convert.ToDecimal(Console.ReadLine()!);

decimal n = p + e;
Console.WriteLine($"A nota de {g} foi {n}.");
