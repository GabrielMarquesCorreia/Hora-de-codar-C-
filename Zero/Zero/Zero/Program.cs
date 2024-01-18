Console.WriteLine("Zero");

Console.WriteLine("Olá! Escreva um número: ");

float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Escreva outro número: ");

float n2 = float.Parse(Console.ReadLine());

while (n2 <= 0)
{
    Console.WriteLine("Por favor escreva um número maior que 0:");
    n2 = float.Parse(Console.ReadLine());
}

double r = n1 + n2;

Console.WriteLine($"A soma entre os números {n1} e {n2} é igual a: {r.ToString("N2")}");
