namespace rocketseat_Desafio_pratico_1;

public static class ExercicioDois
{
    public static void NomeCompleto()
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Nome Completo:");
        Console.WriteLine($"{nome} {sobrenome}");
        Utilidade.Continuar();
    }
}
