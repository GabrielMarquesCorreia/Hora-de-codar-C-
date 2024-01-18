using System.Globalization;

Console.WriteLine("Área do losango");

Console.WriteLine("Digite a diagonal maior de um losango: ");

float dM = float.Parse(Console.ReadLine());

Console.WriteLine("Agora escreva a diagonal menor deste loosango: ");

float dm = float.Parse(Console.ReadLine());

double r = (dM * dm) / 2;

Console.WriteLine($"A área deste losango é igual a: {r.ToString("N2")}");
