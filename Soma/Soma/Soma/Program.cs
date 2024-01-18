Console.WriteLine("Soma");

Console.WriteLine("Olá! Digite um número: ");

float n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");

float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");

float n3 = float.Parse(Console.ReadLine());

if (n1 < n2 && n1 < n3 )
{
    double s = n2 + n3;

    Console.WriteLine($"Os maiores números informados foram {n2} e {n3} e a soma entre eles é igual a: {s}");
}
if (n2 < n1 && n2 < n3)
{
    double s = n1 + n3;

    Console.WriteLine($"Os maiores números informados foram {n1} e {n3} e a soma entre eles é igual a: {s}");
}
if (n3 < n2 && n3 < n1)
{
    double s = n1 + n2;

    Console.WriteLine($"Os maiores números informados foram {n1} e {n2} e a soma entre eles é igual a: {s}");
}
