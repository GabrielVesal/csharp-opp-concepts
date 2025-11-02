namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Herança
    // ============================================
    // Classe filha RECEBE tudo da classe pai
    // Simbolo ':' significa "herda de"
    
    // CLASSE PAI (Base/Superclasse)
    public class AnimalHeranca
    {
        public string Nome { get; set; }
        
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo...");
        }
        
        // VIRTUAL = pode ser sobrescrito
        public virtual void FazerBarulho()
        {
            Console.WriteLine($"{Nome} faz algum som...");
        }
    }
    
    // CLASSE FILHA (Derivada/Subclasse) - HERDA de AnimalHeranca
    public class Cachorro : AnimalHeranca
    {
        public string Raca { get; set; }
        
        // OVERRIDE = sobrescreve método do pai
        public override void FazerBarulho()
        {
            Console.WriteLine($"{Nome} late: Au au!");
        }
        
        // Método ESPECÍFICO (só Cachorro tem)
        public void BuscarBolinha()
        {
            Console.WriteLine($"{Nome} corre atrás da bolinha!");
        }
    }
    
    public class Gato : AnimalHeranca
    {
        public override void FazerBarulho()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
        
        public void Arranhar()
        {
            Console.WriteLine($"{Nome} está arranhando!");
        }
    }
    
    public static class HerancaExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      HERANÇA                              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("🧬 O QUE É?\n");
            Console.WriteLine("   Uma classe RECEBE características e comportamentos");
            Console.WriteLine("   de outra classe, criando hierarquia\n");
            
            Cachorro cachorro = new Cachorro { Nome = "Rex", Raca = "Labrador" };
            Gato gato = new Gato { Nome = "Mimi" };
            
            Console.WriteLine("✅ Cachorro e Gato HERDAM de AnimalHeranca:\n");
            
            // Métodos HERDADOS (do pai)
            Console.WriteLine("Métodos do PAI:");
            cachorro.Comer(); // Método de AnimalHeranca
            gato.Comer();     // Método de AnimalHeranca
            
            Console.WriteLine("\nMétodos SOBRESCRITOS (virtual + override):");
            cachorro.FazerBarulho(); // Comportamento específico
            gato.FazerBarulho();     
            
            Console.WriteLine("\nMétodos ESPECÍFICOS:");
            cachorro.BuscarBolinha(); // Só Cachorro tem
            gato.Arranhar();          // Só Gato tem
            
            Console.WriteLine("\n💡 Herança = Reutilização + Especialização de código!");
        }
    }
}