namespace rocketseat_Desafio_pratico_1;

public class ExercicioCinco
{
    public static void ValidaPlaca()
    {
        Console.Clear();
        Console.WriteLine("Digite a placa do Veículo:");
        string placa = Console.ReadLine();
        bool validade=false;

        if (placa.Count() == 7)
        {
            int count = 0;
            foreach (char c in placa)
            {
                if (count < 3)
                {
                    validade = char.IsLetter(c);
                }
                if (count >= 3)
                {
                    validade = char.IsNumber(c);
                }
                if (!validade) break;
                count++;
            }
        }

        Console.Clear();
        Console.WriteLine($"A placa {placa} é {(validade ? "Válida" : "Inválida")}!");
        Utilidade.Continuar();
    }
}
