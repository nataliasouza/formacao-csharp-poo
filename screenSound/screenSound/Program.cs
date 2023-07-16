string msgBoasVindas = "\t\tOlá! Boas vindas ao Screen Sound!";

void ExibirMsgBoasVindas()
{
    Console.WriteLine(@"
    
█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀

    ");
    Console.WriteLine(msgBoasVindas);
    Console.Write("\n\nAperte uma tecla para acessar o menu de opções");
    Console.ReadKey();
    Console.Clear();
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\n\n=============================================");
    Console.WriteLine("\t\t MENU DE OPÇÕES");
    Console.WriteLine("=============================================");
    Console.WriteLine("\nDigite 1 : Para registrar uma banda");
    Console.WriteLine("Digite 2 : Para mostrar todas as bandas");
    Console.WriteLine("Digite 3 : Para avaliar uma banda");
    Console.WriteLine("Digite 4 : Para exibir a média de uma banda");
    Console.WriteLine("Digite 0 : Para sair");
    Console.WriteLine("\n=============================================");
}

ExibirMsgBoasVindas();
ExibirOpcoesMenu();