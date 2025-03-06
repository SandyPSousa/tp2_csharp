using System;

class ExercicioNove
{
    public static void Executar()
    {
        Console.Write("Digite o seu salário bruto: ");
        string? salarioBrutoInput = Console.ReadLine();
        double salarioBruto = double.Parse(salarioBrutoInput ?? "0");

        double descontoImposto = 0;
        double deducaoIR = 0;

        if (salarioBruto <= 27870.40)
        {
            descontoImposto = 0; 
            deducaoIR = 0;
        }
        else if (salarioBruto <= 37751.55)
        {
            descontoImposto = salarioBruto * 0.075; 
            deducaoIR = 2089.83;
        }
        else if (salarioBruto <= 50148.25)
        {
            descontoImposto = salarioBruto * 0.15; 
            deducaoIR = 5268.16;
        }
        else if (salarioBruto <= 64259.59)
        {
            descontoImposto = salarioBruto * 0.225; 
            deducaoIR = 9576.05;
        }
        else
        {
            descontoImposto = salarioBruto * 0.275; 
            deducaoIR = 13932.41;
        }

        double impostoFinal = descontoImposto - deducaoIR;

        double salarioLiquido = salarioBruto - impostoFinal;

        Console.WriteLine($"\nSalário Bruto: R${salarioBruto:F2}");
        Console.WriteLine($"Imposto Devido: R${impostoFinal:F2}");
        Console.WriteLine($"Salário Líquido: R${salarioLiquido:F2}");
    }
}

