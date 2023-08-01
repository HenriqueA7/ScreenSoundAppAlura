//Screen Sound
using System.Security.Cryptography;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDeBandas = new List<string>();

//tipo dicionário, key nome das bandas, value lista notas
Dictionary<string, List<int>> bandasRegistradas= new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 1, 2, 3 });
bandasRegistradas.Add("The Beatles", new List<int>());

void voltar()
{
    Console.Write("\nPrecione qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n1 registrar uma banda");
    Console.WriteLine("2 mostrar uma banda");
    Console.WriteLine("3 avaliar uma banda");
    Console.WriteLine("4 exibir a nota de uma banda");
    Console.WriteLine("0 sair");

    //o ! faz com que não seja aceito null
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    opcaoEscolhida = 
        opcaoEscolhida != "0" && 
        opcaoEscolhida != "1" && 
        opcaoEscolhida != "2" && 
        opcaoEscolhida != "3" && 
        opcaoEscolhida != "4"
        ? "5"
        : opcaoEscolhida;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    //if (opcaoEscolhidaNumerica >= 0  && opcaoEscolhidaNumerica < 5)
    //{
    //    Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
    //}
    //else 
    //{
    //    Console.WriteLine("\nOpção inválida!");
    //    ExibirOpcoesDoMenu();
    //}
    switch (opcaoEscolhidaNumerica)
    {
        case 0:
            Console.WriteLine("sair");
            break;
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirNotaMedia();
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirLogo();
            ExibirOpcoesDoMenu();
            break;
    }
}

void exibirTituloDaOpcao (string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    exibirTituloDaOpcao("Bandas Registradas:");
    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {i+1}: {listaDeBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    voltar();
}

void AvaliarBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //verificar se a banda existe
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?" +
            $"\nDigite uma nota de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} para a banda {nomeDaBanda} foi registrada com sucesso");
        voltar();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        voltar();
    }
}

void ExibirNotaMedia()
{
    Console.Clear();
    exibirTituloDaOpcao("Nota média da Banda");
    Console.Write("Digite o nome da banda que deseja consulta a nota média: ");
    string nomeDaBanda = Console.ReadLine()!;
    //verificar se a banda existe
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        double notaMedia = notasDaBanda.Average();
        Console.WriteLine($"A nota média da banda {nomeDaBanda} é: {notaMedia}");
        voltar();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        voltar();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

////Jogo desafio - Número aleatório
//Random numeroAleatorio = new Random();
//int numero = numeroAleatorio.Next(1, 101);
//string numeroString = numero.ToString();
//Console.WriteLine("Faz de conta que vc não viu esse número e faça seus testes " + numero);
//string palpite = "";
//int i = 0;
//do
//{
//    string mensagemIncorreto = i == 0
//        ? ""
//        : "\nSeu palite está incorreto, tente novamente.";
//    Console.WriteLine(mensagemIncorreto + "\nQual é o número sorteado entre 1 e 100? Digite seu palpite");
//    palpite = Console.ReadLine();
//    i++;
//}
//while (palpite != numeroString);
//Console.WriteLine("Parabéns! Você acertou");

////Desafio números
//List<int> listaNumeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//for (int i = 0; i < listaNumeros.Count; i++)
//{
//    if (listaNumeros[i] != 0 && listaNumeros[i] % 2 == 0)
//        Console.WriteLine(listaNumeros[i]);
//}
//foreach (int numero in listaNumeros)
//{
//    if (numero != 0 && numero % 2 == 0) Console.WriteLine(numero);
//}

////exercício
//Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
//};

//List<int> vendasFerrari = vendasCarros["Ferrari LaFerrari"];
//double mediaVendasFerrari = vendasFerrari.Average();
//Console.WriteLine(mediaVendasFerrari);