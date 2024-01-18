Console.WriteLine("Trapézio");

Console.WriteLine("Escreva a base maior de um trapézio");

float bM = float.Parse(Console.ReadLine());

Console.WriteLine("Agora escreve a base menor deste trapézio: ");

float bm = float.Parse(Console.ReadLine());

Console.WriteLine("Agora escreva a altura deste trápézio: ");

float a = float.Parse(Console.ReadLine());

double r = (bM * bm) * a / 2;

Console.WriteLine($"A área deste trapézio é igual a: {r.ToString("N2")}");
