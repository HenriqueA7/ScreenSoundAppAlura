//Screen Sound
using System.Security.Cryptography;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
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

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
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
            Console.WriteLine("registrar");
            break;
        case 2:
            Console.WriteLine("mostrar");
            break;
        case 3:
            Console.WriteLine("avaliar");
            break;
        case 4:
            Console.WriteLine("exibir");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            ExibirOpcoesDoMenu();
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

//Jogo desafio - Número aleatório
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