using System.ComponentModel;

namespace rocketseat_Desafio_pratico_1;

public class ExercicioSeis
{
     public static void DataAtual()
    {
        int opcao = -1;
        DateTime agora = DateTime.Now;
        do
        {
            Console.Clear();
            Console.WriteLine("=====   Qual o Formato?  =====");
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
            Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
            Console.WriteLine("4 - A data com o mês por extenso");
            Console.WriteLine("0 - Voltar");

            Console.WriteLine("==============================");
            Console.Write("Digite a Opção: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            switch (opcao)
            {
                case 0:
                    Utilidade.Sair();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine(agora.ToString("dddd, 'dia' dd 'de' MMMM 'de' yyyy, HH 'horas,' mm 'minutos e' ss 'segundos'"));
                    Utilidade.Continuar();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(agora.ToString("dd/MM/yy"));
                    Utilidade.Continuar();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine(agora.ToString("HH:ss"));
                    Utilidade.Continuar();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine(agora.ToString("dd/MMMM/yy"));
                    Utilidade.Continuar();
                    break;
                default:
                    opcao = Utilidade.OpcInvalida();
                    break;

            }


        } while (opcao != 0);
    }
}
