

using rocketseat_Desafio_pratico_1;

int opcao=-1;

do
{
    Console.Clear();
    Console.WriteLine("==========   Menu  ==========");
    Console.WriteLine("1 - Exercício 1: Boas Vindas");
    Console.WriteLine("2 - Exercício 2: Nome e Sobrenome");
    Console.WriteLine("3 - Exercício 3: Operações com 2 Valores");
    Console.WriteLine("4 - Exercício 4: Contar letras");
    Console.WriteLine("5 - Exercício 5: Validar Placa");
    Console.WriteLine("6 - Exercício 6: Exibir formatos de Data Atual");
    Console.WriteLine("0 - Sair");


    Console.WriteLine("=============================");
    Console.Write("Digite a Opção: ");
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

        case 4:
            ExercicioQuatro.Palavras();
            break;
        case 5:
            ExercicioCinco.ValidaPlaca();
            break;
        case 6:
            ExercicioSeis.DataAtual();
            break;
        default:
            opcao = Utilidade.OpcInvalida();
            break;

    }
    

} while (opcao != 0);