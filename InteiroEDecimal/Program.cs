Console.WriteLine("--- Inteiro e Decimal ---");

Thread.Sleep(1000);

Console.Write("Digite um número: ");
double num = Convert.ToDouble(Console.ReadLine()!);

int numint = (int)num;
double numdec = num - numint;

Console.WriteLine($"Parte inteira: {numint}");
Console.WriteLine($"Parte decimal: {numdec}");