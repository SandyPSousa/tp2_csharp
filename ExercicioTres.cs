using System;

class ExercicioTres
{
    public static void Executar()
    {
        Console.Write("Digite a primeira data (formato: dd/MM/yyyy): ");
        string? data1Input = Console.ReadLine();
        DateTime data1 = DateTime.ParseExact(data1Input, "dd/MM/yyyy", null);

        Console.Write("Digite a segunda data (formato: dd/MM/yyyy): ");
        string? data2Input = Console.ReadLine();
        DateTime data2 = DateTime.ParseExact(data2Input, "dd/MM/yyyy", null);

        TimeSpan diferenca = data2 - data1;

        int anos = data2.Year - data1.Year;
        if (data2.Month < data1.Month || (data2.Month == data1.Month && data2.Day < data1.Day))
        {
            anos--;
        }

        int meses = data2.Month - data1.Month + (data2.Year - data1.Year) * 12;
        if (data2.Day < data1.Day)
        {
            meses--;
        }

        Console.WriteLine($"A diferença entre as datas é de {anos} ano(s), {meses} mês(meses) e {diferenca.Days} dia(s).");
    }
}
