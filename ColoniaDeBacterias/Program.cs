Console.WriteLine("--- Colônia de Bactérias ---");
Console.WriteLine();

Console.Write("Qual o número de indivíduos? ");
double n = Convert.ToDouble(Console.ReadLine()!);

double t = 2 * (Math.Log(n / 2000) / Math.Log(2));

Console.WriteLine($"A colônia atingirá {n} em {t:N1} horas");
