Console.Write("Graus em Celsius: ");
double c = Convert.ToDouble(Console.ReadLine()!);

double cf = c * 1.8 + 32;
Console.WriteLine($"{c}°C equivalem  a {cf}°F");

Console.WriteLine();

Console.Write("Graus em Fahrenheit: ");
double f = Convert.ToDouble(Console.ReadLine()!);

double fc = (f - 32) / 1.8;
Console.WriteLine($"{f}°F equivalem  a {fc:N1}°C");
