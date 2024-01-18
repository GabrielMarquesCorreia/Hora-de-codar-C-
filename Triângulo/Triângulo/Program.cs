Console.WriteLine("Triângulo");

Console.WriteLine("Escreva a base de um triângulo: ");

float b = float.Parse(Console.ReadLine());

Console.WriteLine("Agora escreva a altura deste triângulo: ");

float a = float.Parse(Console.ReadLine());

double r = (b * a) / 2;

Console.WriteLine($"A área deste triângulo é igual a: {r.ToString("N2")}");
