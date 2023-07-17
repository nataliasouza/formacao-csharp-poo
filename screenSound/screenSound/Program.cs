
string msgBoasVindas = "\t\tOlá! Boas vindas ao Screen Sound!";

Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
listaDeBandas.Add("Legião Urbana", new List<int> { 10, 9, 8 });
listaDeBandas.Add("Guns n' Roses", new List<int> { 9, 9 });
listaDeBandas.Add("Skank", new List<int> { 10, 9, 7 });


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

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;    
    int aumentarSeparadorTextos = quantidadeDeLetras * 3;//a variavel foi triplicada, para centralizar o titulo
    string separadorTextos = string.Empty.PadLeft(aumentarSeparadorTextos, '=');
    Console.WriteLine($"\n{separadorTextos}" );
    Console.WriteLine($"\t\t{titulo}");
    Console.WriteLine($"{separadorTextos}");
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
    ExibirTituloDaOpcao("REGISTRO DE BANDA");
    Console.Write("\nDigite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");    
    VoltarParaMenuPrincipal();    
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("BANDAS REGISTRADAS");    
    Console.WriteLine($"\nQuantidade de bandas cadastradas: {listaDeBandas.Count}\n");

    foreach (string banda in listaDeBandas.Keys)
    {        
        Console.WriteLine($"\tBanda: {banda}");        
    }
    
    VoltarParaMenuPrincipal();
}