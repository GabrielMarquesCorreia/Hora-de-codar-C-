Console.WriteLine("Idade");

Console.WriteLine("Qual é o seu nome? ");

string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}! Em qual ano você nasceu? ");

float year = float.Parse(Console.ReadLine());

double age = 2024 - year;

if (age < 18)
{
    Console.WriteLine($"{nome}, você nasceu em {year} e tem {age} anos, você é menor de idade e por isso não pode entrar no servidor.");
}
else
{
    Console.WriteLine($"Seja muito Bem-Vindo(a) ao servidor {nome}! Você nasceu em {year}, portanto você tem {age} anos! ");
}