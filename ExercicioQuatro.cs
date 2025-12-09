namespace rocketseat_Desafio_pratico_1;

public class ExercicioQuatro
{
    public static void Palavras()
    {
        Console.Clear();
        Console.WriteLine("Digite a(s) palavra(s):");
        string entrada = Console.ReadLine();
        int count = 0;

        foreach (char letra in entrada)
        {
            if (letra != ' ')
            {
                count++;
            }
        }

        Console.Clear();
        Console.WriteLine($"A(s) palavra(s) digitada(s) tem {count} caractere(s)");
        Utilidade.Continuar();
    }
}
