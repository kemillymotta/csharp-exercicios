Console.WriteLine("--- Vivendo de dividendos ---");
Console.Write("Gastos mensais (em R$): ");
decimal x = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("Rendimentos mensais (%): ");
decimal y = Convert.ToDecimal(Console.ReadLine()!);

decimal z = x / (y / 100);
Console.WriteLine($"Para receber R$ {x:N2} por mês com rendimentos de {y} você precisa ter investido R$ {z:N2}.");