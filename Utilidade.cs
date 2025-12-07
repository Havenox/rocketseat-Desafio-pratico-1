namespace rocketseat_Desafio_pratico_1;

public class Utilidade
{
    public static void Continuar()
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
    }

    public static int OpcInvalida()
    {
        Console.Clear();
        Console.WriteLine("Opção Inválida!");
        Utilidade.Continuar();
        return -1;
    }

    public static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Obrigado por utilizar Nosso Programa!");
    }
}



