Console.Write("Altura (m): ");
double m = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Peso (kg): ");
double kg = Convert.ToDouble(Console.ReadLine()!);

double imc = kg / Math.Pow(m, 2);
Console.WriteLine($"IMC: {imc} kg/m²");
