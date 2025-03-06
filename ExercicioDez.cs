using System;

class ExercicioDez
{
    public static void Executar()
    {
        Console.Write("Digite um número para iniciar a contagem regressiva: ");
        string? numeroInput = Console.ReadLine();
        int numero = int.Parse(numeroInput ?? "0");

        for (int i = numero; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(i);
            }
        }

        Console.WriteLine(); 
    }
}
