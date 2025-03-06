using System;

class ExercicioSete
{
    public static void Executar()
    {
        Console.Write("Digite um número inteiro: ");
        string? numeroInput = Console.ReadLine();
        int numero = int.Parse(numeroInput ?? "0");

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
        }
    }
}
