

namespace rocketseat_Desafio_pratico_1;

public class ExercicioTres
{
    public static void DoisNumeros()
    {
        bool correto = false;
        double numero1, numero2;
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro Número:");
            correto = double.TryParse(Console.ReadLine(), out numero1);
            if (!correto) Utilidade.OpcInvalida();
        } while (!correto);

        do
        {
            Console.Clear();
            Console.WriteLine("Digite o segundo Número:");
            correto = double.TryParse(Console.ReadLine(), out numero2);
            if (!correto) Utilidade.OpcInvalida();
        } while (!correto);


        Console.Clear();
        Console.WriteLine($"Soma ============= {numero1} + {numero2} = {numero1 + numero2}");
        Console.WriteLine($"Subtração ======== {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"Multiplicação ==== {numero1} / {numero2} = {numero1 * numero2}");
        Console.WriteLine($"Divisão ========== {numero1} * {numero2} = {numero1 / numero2}");
        Console.WriteLine($"Média ============ {numero1} e {numero2} = {(numero1 + numero2)/2}");

        Utilidade.Continuar();
    }
}
