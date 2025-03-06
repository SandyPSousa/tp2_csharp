using System;

class ExercicioUm
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número do seu dia de nascimento: ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Digite o número do seu mês de nascimento: ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Digite o número do seu do ano de nascimento: ");
        int ano = int.Parse(Console.ReadLine());

        DateTime nascimento = new DateTime(ano, mes, dia);
        DateTime hoje = DateTime.Now;

        int anos = hoje.Year - nascimento.Year;
        int meses = hoje.Month - nascimento.Month;
        int dias = hoje.Day - nascimento.Day;

        if (dias < 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(hoje.Year, hoje.Month == 1 ? 12 : hoje.Month - 1);
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Você tem {anos} anos, {meses} mes(meses) e {dias} dias.");
        Console.ReadLine();
    }
}

