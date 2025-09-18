Console.Write("Salário: (R$): ");
double s = Convert.ToDouble(Console.ReadLine()!);

double fgts = s * 0.08;
Console.WriteLine($"FGTS: R$ {fgts}");