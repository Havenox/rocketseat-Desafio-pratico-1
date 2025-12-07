

using rocketseat_Desafio_pratico_1;

int opcao=-1;

do
{
    Console.Clear();
    Console.WriteLine("==========   Menu  ==========");
    Console.WriteLine("1 - Exercício 1: Boas Vindas");
    Console.WriteLine("2 - Exercício 2: Nome e Sobrenome");
    Console.WriteLine("3 - Exercício 3: Operações com 2 Valores");
    Console.WriteLine("=============================");
    Console.WriteLine("Digite a Opção:");
    if(!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 0:
            Utilidade.Sair();
            break;  
        case 1:
            ExercicioUm.BoasVindas();
            break;

        case 2:
            ExercicioDois.NomeCompleto();
            break;

        case 3:
            ExercicioTres.DoisNumeros();
            break;
        default:
            opcao = Utilidade.OpcInvalida();
            break;

    }
    

} while (opcao != 0);