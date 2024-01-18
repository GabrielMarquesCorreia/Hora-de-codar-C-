Console.WriteLine("Área do círculo");

Console.WriteLine("Escreva a base de um círculo: ");

float b = float.Parse(Console.ReadLine());

double r = 3.14 * b;

Console.WriteLine($"A área deste círculo é igual a: {r.ToString("N2")}");
