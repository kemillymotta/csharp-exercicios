Console.WriteLine("Cálculo da soma entre dois números");

Console.Write("Digite o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine()!);

int soma = n1 + n2;
Console.WriteLine($"Soma: {soma}");
