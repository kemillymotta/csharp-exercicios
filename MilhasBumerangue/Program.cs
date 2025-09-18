Console.WriteLine("--- Milhas Bumerangue");

Thread.Sleep(1000);

Console.Write("Percentual de bônus: ");
double b = Convert.ToDouble(Console.ReadLine()!) / 100;
Console.Write("Percentual de retorno: ");
double r = Convert.ToDouble(Console.ReadLine()!) / 100;
Console.Write("Pontos a transferir: ");
double p = Convert.ToDouble(Console.ReadLine()!);

int origem = (int)(p - (r * p));
Console.WriteLine($"Pontos reduzir na origem: {origem}");
int destino = (int)(p + (b * p));
Console.WriteLine($"Pontos a acrescentar no destino: {destino}");



