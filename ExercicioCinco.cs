using System;

class ExercicioCinco
{
    public static void Executar()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        string? celsiusInput = Console.ReadLine();
        double celsius = double.Parse(celsiusInput ?? "0");

        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine("\n### Temperaturas Convertidas ###");
        Console.WriteLine($"{celsiusInput}°C em Fahrenheit é igual a: {fahrenheit:F2}°F");
        Console.WriteLine($"{celsiusInput}°C em Kelvin é igual a: {kelvin:F2}K");
    }
}
