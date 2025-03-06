using System;

class ExercicioDois
{
    public static void Executar()
    {
        Console.Write("Digite o número do seu dia de nascimento: ");
        string? diaInput = Console.ReadLine();
        int dia = int.Parse(diaInput ?? "0");

        Console.Write("Digite o número do seu mês de nascimento: ");
        string? mesInput = Console.ReadLine();
        int mes = int.Parse(mesInput ?? "0");

        DateTime hoje = DateTime.Now;
        DateTime proximoAniversario = new DateTime(hoje.Year, mes, dia);

        if (proximoAniversario < hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int diasFaltando = (proximoAniversario - hoje).Days;

        Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário!");
    }
}



