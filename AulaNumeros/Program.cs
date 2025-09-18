/* var a = 10; // int
var b = 10.0; // double
var c = 10.0m; // decimal

Console.WriteLine($"{a.GetType()} {b.GetType()} {c.GetType()}");

// conversão, ! = sem valor nulo
Console.WriteLine("Inteiro: ");
var entrada = Console.ReadLine()!;

int numeroEntrada = Convert.ToInt32(entrada); // admite um possivel valor nulo
int numeroEntradaDois = int.Parse(entrada); // certeza que tem um valor 
bool foiConvertido = int.TryParse(entrada, out int numeroEntradaTres);

Console.WriteLine($"{numeroEntrada}, {numeroEntradaDois}, {numeroEntradaTres}");

// conversao explicita (decimal)
Console.WriteLine("Decimal: ");
var novaEntrada = Console.ReadLine();
decimal numeroRealEntrada =
    Convert.ToDecimal(novaEntrada);
Console.WriteLine($"{numeroRealEntrada}");  

int numeroRealEntradaInteiro = (int) numeroRealEntrada; */

/*
Console.Write("X: ");
double x = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Y: ");
double y = Convert.ToDouble(Console.ReadLine()!);


var soma = x + y;
var subtracao = x - y;
var multiplicacao = x * y;
var divisao = x / y;
var resto = x % y;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Resto: {resto}"); */

/* double n1 = 2, n2 = 3, n3 = 1;
double r1 = n1 * n2 + n3;
double r2 = n1 * (n2 + n3);
double r3 = (n1 * n2) + n3;
double r4 = ((n1 * n2) + n3) / n1;

Console.WriteLine($"{n1} * {n2} + {n3} = {r1}");
Console.WriteLine($"{n1} * ({n2} + {n3}) = {r2}");
Console.WriteLine($"({n1} * {n2}) + {n3} = {r3}");
Console.WriteLine($"(({n1} * {n2}) + {n3}) / {n1} = {r4}"); */

/* Console.Write("X: ");
double x = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Y: ");
double y = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Z: ");
double z = Convert.ToDouble(Console.ReadLine()!); 

double media1 = (x + y + z) / 3;
Console.WriteLine($"A média aritmética entre os números é: {media1:N1}"); */

Console.Write("A: ");
decimal a = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("B: ");
decimal b = Convert.ToDecimal(Console.ReadLine()!);
Console.Write("C: ");
decimal c = Convert.ToDecimal(Console.ReadLine()!);

decimal media2 = (a + b + c) / 3; 
Console.WriteLine($"A média aritmética entre os números é: {media2:N1}");

