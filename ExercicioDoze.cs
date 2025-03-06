using System;

class ExercicioDoze
{
    public static void Executar()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        Console.WriteLine(numeroSecreto);
        int palpite = 0;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (palpite != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            string? palpiteInput = Console.ReadLine();

            if (int.TryParse(palpiteInput, out palpite))
            {
                

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior. Tente novamente.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor. Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns, você acertou! O número secreto era: {numeroSecreto}!");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}
