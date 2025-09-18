Console.WriteLine("Digite os lados do triângulo desejado.");
Console.WriteLine();

Console.Write("Lado 1: ");
double a = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Lado 2: ");
double b = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Lado 3: ");
double c = Convert.ToDouble(Console.ReadLine()!);

double p = (a + b + c) / 2;
Console.WriteLine($"Semiperímetro: {p}");
double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine($"Área: {area}");


