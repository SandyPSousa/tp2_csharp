using System;

class ExercicioOnze
{
    public static void Executar()
    {
        Console.Write("Digite um número para calcular a tabuada: ");
        string? numeroInput = Console.ReadLine();
        int numero = int.Parse(numeroInput ?? "0");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
