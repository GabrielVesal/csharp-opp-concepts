using OPP.Examples;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            ExibirMenu();
            string? opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao)
            {
                case "1": ClassesObjetosExample.Executar(); break;
                case "2": EncapsulamentoExample.Executar(); break;
                case "3": HerancaExample.Executar(); break;
                case "4": PolimorfismoExample.Executar(); break;
                case "5": AbstracaoExample.Executar(); break;
                case "6": PropriedadesIndexersExample.Executar(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!\n"); break;
            }

            if (opcao != "7")
                Pausar();
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== CONCEITOS DE POO ===\n");
        Console.WriteLine("1 - Classes e Objetos");
        Console.WriteLine("2 - Encapsulamento");
        Console.WriteLine("3 - Herança");
        Console.WriteLine("4 - Polimorfismo");
        Console.WriteLine("5 - Abstração");
        Console.WriteLine("6 - Propriedades e Indexers");
        Console.WriteLine("0 - Sair");
        Console.Write("\nEscolha: ");
    }

    static void Pausar()
    {
        Console.Write("\nPressione qualquer tecla...");
        Console.ReadKey();
    }
}