Console.Write("Entre com a medida (em milhas): ");
decimal m = Convert.ToDecimal(Console.ReadLine()!);

decimal km = m * 1.609m;
Console.WriteLine($"{km:N1} Km");