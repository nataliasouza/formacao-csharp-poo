
string msgBoasVindas = "\t\tOlá! Boas vindas ao Screen Sound!";
List<string> listaDeBandas = new List<string> 
{ 
    "Legião Urbana", "Guns n' Roses", "U2", "Skank"
};

void ExibirMsgBoasVindas()
{
    Console.WriteLine(@"
    
█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀

    ");
    Console.WriteLine(msgBoasVindas);
    Console.Write("\n\nAperte uma tecla para acessar o menu de opções ");
    Console.ReadKey();
    Console.Clear();
}

void VoltarParaMenuPrincipal()
{    
    Console.Write("\n\nAperte uma tecla para voltar ao menu de opções");    
    Console.ReadKey();
    Console.Write("\nretornando ao menu principal...");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
}

void ExibirOpcoesMenu()
{
    Console.Clear();
    Console.WriteLine("\n=============================================");
    Console.WriteLine("\t\t MENU DE OPÇÕES");
    Console.WriteLine("=============================================");
    Console.WriteLine("\nDigite 1 : Para registrar uma banda");
    Console.WriteLine("Digite 2 : Para mostrar todas as bandas");
    Console.WriteLine("Digite 3 : Para avaliar uma banda");
    Console.WriteLine("Digite 4 : Para exibir a média de uma banda");
    Console.WriteLine("Digite 0 : Para sair");
    Console.WriteLine("\n=============================================");
    Console.Write("\nDigite a sua opção: ");

    string opcao = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcao);

    switch (opcaoEscolhidaNumerica)
    {
        case 0:

            Console.Clear();
            Console.Write("\nAguardamos o seu retorno! :)\n");            
            break;

        case 1:
            
            Console.Clear();
            RegistrarBanda();
            break;

        case 2:
            Console.Clear();
            MostrarBandasRegistradas();
            break;

        case 3:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;

        case 4:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhidaNumerica}");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMsgBoasVindas();
ExibirOpcoesMenu();

void RegistrarBanda()
{
    Console.WriteLine("===================================================");
    Console.WriteLine("\t\tREGISTRO DE BANDAS");
    Console.WriteLine("===================================================");
    Console.Write("\nDigite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Console.WriteLine("\n===================================================");
    VoltarParaMenuPrincipal();    
}

void MostrarBandasRegistradas()
{
    Console.WriteLine("===================================================");
    Console.WriteLine("\t\tBANDAS REGISTRADAS");
    Console.WriteLine("===================================================");
    Console.WriteLine($"\nQuantidade de bandas cadastradas: {listaDeBandas.Count}\n");

    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"\tBanda {i + 1}: {listaDeBandas[i]}");
    //}

    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"\tBanda {listaDeBandas.IndexOf(banda)+1}: {banda}");
    }
    
    VoltarParaMenuPrincipal();
}