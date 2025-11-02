namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Classes e Objetos
    // ============================================
    // CLASSE = Molde/Template que define estrutura
    // OBJETO = Instância concreta criada a partir da classe
    
    public class Pet
    {
        // PROPRIEDADES (características)
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        // MÉTODO (ação/comportamento)
        public void FazerSom()
        {
            Console.WriteLine($"{Nome} faz algum som...");
        }
    }
    
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome} e tenho {Idade} anos.");
        }
    }
    
    public static class ClassesObjetosExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  CLASSES E OBJETOS                        ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("📦 O QUE É?\n");
            Console.WriteLine("   CLASSE = Molde/Template");
            Console.WriteLine("   OBJETO = Instância criada a partir da classe\n");
            
            // Criando OBJETOS (instâncias)
            Pet gato1 = new Pet { Nome = "Mimi", Idade = 2 };
            Pet cachorro1 = new Pet { Nome = "Rex", Idade = 5 };
            
            Console.WriteLine("✅ 2 objetos criados da mesma classe Pet:\n");
            gato1.FazerSom();
            cachorro1.FazerSom();
            
            Console.WriteLine("\n─".PadRight(65, '─') + "\n");
            
            Pessoa pessoa1 = new Pessoa { Nome = "João", Idade = 25 };
            Pessoa pessoa2 = new Pessoa { Nome = "Maria", Idade = 30 };
            
            Console.WriteLine("✅ Objetos de outra classe (Pessoa):\n");
            pessoa1.Apresentar();
            pessoa2.Apresentar();
            
            Console.WriteLine("\n💡 Cada objeto é INDEPENDENTE!");
            Console.WriteLine("   Criados da mesma CLASSE mas com DADOS diferentes!\n");
        }
    }
}