//declaração de variáveis 
string nome;
char primeiraLetraDoMeuNome;
int idade;
double altura;
decimal salario;

//atribuição de variáveis
Console.Write("Qual o seu nome? ");
nome = Console.ReadLine()!.ToUpper();
Console.Write("Qual a primeira letra do seu nome? ");
primeiraLetraDoMeuNome = Console.ReadLine()![0];
Console.WriteLine();
Console.Write("Qual a sua idade? ");
idade = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Qual a sua altura? ");
altura = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Qual o seu salário? ");
salario = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine();
//com interpolação
Console.WriteLine($"Meu nome é: {nome}");
Console.WriteLine($"Primeira Letra do meu nome: {primeiraLetraDoMeuNome}");
Console.WriteLine($"Eu tenho {idade} anos");
Console.WriteLine($"Altura: {altura:N2}cm");
Console.WriteLine($"Salário mensal: {salario:C2}");

/* sem interpolação
Console.Write("Meu nome é: ");
Console.WriteLine(nome);
Console.Write("Primeira Letra do meu nome: ");
Console.WriteLine(primeiraLetraDoMeuNome);
*/