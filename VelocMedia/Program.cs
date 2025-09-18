Console.Write("Distância percorrida (m): ");
double m = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Tempo gasto (s): ");
double s = Convert.ToDouble(Console.ReadLine()!);

double v = m / s;
Console.WriteLine($"Velocidade média: {v:N1} m/s");

