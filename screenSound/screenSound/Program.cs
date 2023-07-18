
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
            Environment.Exit(0);
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
            Console.Clear();
            AvaliarBanda();
            break;

        case 4:
            Console.Clear();
            ExibirAvaliacaoDaBanda();
            break;

        default:
            Console.Clear();
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
    ValidarRegistroDaBanda(nomeDaBanda);        
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

void AvaliarBanda()
{
    ExibirTituloDaOpcao("AVALIAR BANDA");
    Console.Write("\nDigite o nome da banda deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (listaDeBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaDeBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\n\nA nota {nota} foi registrada com sucesso, para a Banda {nomeDaBanda}!");
        VoltarParaMenuPrincipal();

    }else    
        Console.WriteLine($"\n\nA Banda {nomeDaBanda} não foi encontrada!");
        VoltarParaMenuPrincipal();    
}

void ExibirAvaliacaoDaBanda()
{    
    Console.Write("Digite o nome da banda para saber a média: ");
    string nomeDaBanda = (Console.ReadLine()!);

    if (listaDeBandas.ContainsKey(nomeDaBanda))
    {
        //List<int> notasDaBanda = listaDeBandas[nomeDaBanda];
        //Console.WriteLine($"\n\nA média de notas da Banda {nomeDaBanda} foi: {notasDaBanda.Average():F2}");
        double notasDaBanda = listaDeBandas[nomeDaBanda].Average();
        Console.WriteLine($"\n\nA média de notas da Banda {nomeDaBanda} foi: {notasDaBanda:F2}");
        VoltarParaMenuPrincipal();

    }else
        Console.WriteLine($"\nO nome da Banda {nomeDaBanda} não está registrado!");
        Console.Write("\nAperte uma tecla para prossegui com o registro!");
        Console.ReadKey();        
        Console.Clear();
        RegistrarBanda();    
}

void ValidarRegistroDaBanda(string nomeDaBanda)
{
    while (listaDeBandas.ContainsKey(nomeDaBanda) == true)
    {
        Console.WriteLine($"O nome da Banda {nomeDaBanda} já está registrado!");
        Console.Write("\nDigite outro nome de banda: ");
        string novoNomeDaBanda = Console.ReadLine()!;
        nomeDaBanda = novoNomeDaBanda;
        Console.Clear();      
    }

    listaDeBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\n\nA banda {nomeDaBanda} foi registrada com sucesso!");
}