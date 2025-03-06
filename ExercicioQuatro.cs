using System;

class ExercicioQuatro
{
    public static void Executar()
    {
        Console.Write("Digite o seu nome: ");
        string? nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        string? idadeInput = Console.ReadLine();
        int idade = int.Parse(idadeInput ?? "0");

        Console.Write("Digite o seu telefone: ");
        string? telefone = Console.ReadLine();

        Console.Write("Digite o seu e-mail: ");
        string? email = Console.ReadLine();

        Console.WriteLine("\n### Dados Cadastrados ###");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
    }
}
