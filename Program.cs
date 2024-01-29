namespace ScreenSound
{
    public class ScreenSound
    {
        
        private const string mensagemBoasVindas = "Boas vindas ao Screen Sound";
        static string mensagemDeBoasVindas = mensagemBoasVindas;
        static Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

        static void Main(string[] args)
        {
            ExibirMenu();
        }
        static void ExibirLogo()
        {
            Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

            Console.WriteLine(mensagemDeBoasVindas);
        }

        static void ExibirMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda" +
                              "\nDigite 2 para mostrar todas as bandas" +
                              "\nDigite 3 para avaliar uma banda" +
                              "\nDigite 4 para exibir a média de uma banda" +
                              "\nDigite 5 para sair");

            Console.Write("\nDigite a sua opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    ApresentarBandas();
                    break;
                case 3:
                    AvaliarBanda();
                    break;
                case 4:
                    ExibirMedia();
                    break;
                case 5:
                    Console.WriteLine("Tchau");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }

        static void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("REGISTRAR BANDA");
            Console.Write("Digite o nome da banda que deseja resgistrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("Digite qualquer tecla para voltar ao Menu");
            Console.ReadKey();
            Console.Clear();
            ExibirMenu();
        }

        static void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos);
        }

        static void ApresentarBandas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("EXIBINDO TODAS AS BANDAS REGISTRADAS");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirMenu();
        }

        static void AvaliarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("AVALIAR UMA BANDA");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
                int notaBanda = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomeDaBanda].Add(notaBanda);
                Console.WriteLine($"\nA nota {notaBanda} foi registrada com sucesso!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
            }
        }

        static void ExibirMedia()
        {
            Console.Clear();
            ExibirTituloDaOpcao("EXIBIR MÉDIA DA BANDA");
            Console.Write("Digite o nome da banda que deseja exibir a média: ");
            string nomeBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                List<int> notasDaBanda = new List<int>();
                Console.WriteLine($"\nA média da banda {nomeBanda} é {notasDaBanda.Average()}.");
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
            }   
        }
    }
    
}
        
