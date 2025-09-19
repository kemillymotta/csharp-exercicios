Console.WriteLine("Juros simples");

Console.Write("Capital: ");
decimal c = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Taxa de juros: ");
decimal i = Convert.ToDecimal(Console.ReadLine()!) / 100;
Console.Write("Tempo: ");
int t = Convert.ToInt32(Console.ReadLine()!);

decimal j = c * i * t;
decimal m = c + j;

Console.WriteLine($"Juros (R$): {j:N1}");
Console.WriteLine($"Montante (R$): {m:N1}");
