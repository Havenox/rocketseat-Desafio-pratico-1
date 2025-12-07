

namespace rocketseat_Desafio_pratico_1;

public class ExercicioUm
{
    public static void BoasVindas()
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        Utilidade.Continuar();
    }
}
