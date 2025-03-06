using System;

class ExercicioOito
{
    public static void Executar()
    {
        Console.Write("Digite uma nota de 0 a 10: ");
        string? notaInput = Console.ReadLine();
        double nota = double.Parse(notaInput ?? "0");

        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida! A nota deve estar entre 0 e 10.");
        }
        else if (nota >= 0 && nota < 4)
        {
            Console.WriteLine("Classificação: Insuficiente");
        }
        else if (nota >= 4 && nota < 6)
        {
            Console.WriteLine("Classificação: Regular");
        }
        else if (nota >= 6 && nota < 8)
        {
            Console.WriteLine("Classificação: Bom");
        }
        else
        {
            Console.WriteLine("Classificação: Excelente");
        }
    }
}
