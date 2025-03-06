using System;

class ExercicioSeis
{
    public static void Executar()
    {
        Console.Write("Digite a sua altura (em cm): ");
        string? alturaInput = Console.ReadLine();
        double altura = double.Parse(alturaInput ?? "0") / 100;

        Console.Write("Digite o seu peso (em kg): ");
        string? pesoInput = Console.ReadLine();
        double peso = double.Parse(pesoInput ?? "0");

        double imc = peso / (altura * altura);

        string classificacao = ClassificarIMC(imc, altura, peso);

        Console.WriteLine($"\nSeu IMC é: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
    //informações baseadas nos valores dessa tabela: https://www.msdmanuals.com/pt/profissional/multimedia/table/%C3%ADndice-de-massa-corporal-imc
    public static string ClassificarIMC(double imc, double altura, double peso)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            return "Peso Normal";
        }
        else if (imc >= 25 && imc < 30)
        {
            return "Sobrepeso";
        }
        else if (imc >= 30 && imc < 35)
        {
            return "Obesidade Classe I";
        }
        else if (imc >= 35 && imc < 40)
        {
            return "Obesidade Classe II";
        }
        else
        {
            return "Obesidade Classe III";
        }
    }

    public static string VerificarPesoIdeal(double altura, double peso)
    {
        if (altura >= 152 && altura <= 155)
        {
            if (peso >= 44 && peso <= 58)
                return "Peso ideal (Normal)";
            else if (peso > 58 && peso <= 69)
                return "Peso ideal (Sobrepeso)";
            else if (peso > 69 && peso <= 82)
                return "Peso ideal (Obesidade Classe I)";
            else if (peso > 82 && peso <= 93)
                return "Peso ideal (Obesidade Classe II)";
            else
                return "Peso ideal (Obesidade Classe III)";
        }
        else if (altura >= 157 && altura <= 160)
        {
            if (peso >= 47 && peso <= 61)
                return "Peso ideal (Normal)";
            else if (peso > 61 && peso <= 74)
                return "Peso ideal (Sobrepeso)";
            else if (peso > 74 && peso <= 87)
                return "Peso ideal (Obesidade Classe I)";
            else if (peso > 87 && peso <= 100)
                return "Peso ideal (Obesidade Classe II)";
            else
                return "Peso ideal (Obesidade Classe III)";
        }

        return "Fora da faixa de peso";
    }
}
