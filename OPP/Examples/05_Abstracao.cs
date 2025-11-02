namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Abstração
    // ============================================
    // Simplificar complexidade mostrando apenas o essencial
    // Define "O QUE" fazer, não "COMO" fazer
    
    // ============================================
    // CLASSE ABSTRATA
    // ============================================
    // Não pode ser instanciada diretamente
    // Pode ter métodos abstratos E concretos
    
    public abstract class Forma
    {
        public string Nome { get; set; }
        
        // MÉTODO ABSTRATO = SEM implementação
        // FORÇA classes filhas a implementar
        public abstract double CalcularArea();
        
        // MÉTODO CONCRETO = TEM implementação
        public void Informar()
        {
            Console.WriteLine($"Forma: {Nome}");
        }
    }
    
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        
        // OBRIGATÓRIO: implementar método abstrato
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
    
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
    }
    
    // ============================================
    // INTERFACE
    // ============================================
    // Contrato PURO - só definições
    // Classe PODE implementar múltiplas interfaces
    
    public interface IVoador
    {
        void Voar();
    }
    
    public interface INadador
    {
        void Nadar();
    }
    
    public class Passaro : IVoador
    {
        public string Nome { get; set; }
        
        public void Voar()
        {
            Console.WriteLine($"{Nome} está voando! 🦅");
        }
    }
    
    public class Aviao : IVoador
    {
        public string Modelo { get; set; }
        
        public void Voar()
        {
            Console.WriteLine($"{Modelo} está voando! ✈️");
        }
    }
    
    // Pode implementar MÚLTIPLAS interfaces
    public class Pato : IVoador, INadador
    {
        public string Nome { get; set; }
        
        public void Voar()
        {
            Console.WriteLine($"{Nome} voa baixo! 🦆");
        }
        
        public void Nadar()
        {
            Console.WriteLine($"{Nome} está nadando! 🏊");
        }
    }
    
    public static class AbstracaoExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                     ABSTRAÇÃO                              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("🎨 O QUE É?\n");
            Console.WriteLine("   Simplificar complexidade mostrando apenas o essencial");
            Console.WriteLine("   Define 'O QUE' fazer, não 'COMO' fazer\n");
            
            Console.WriteLine("📋 FERRAMENTAS:\n");
            Console.WriteLine("   1. CLASSE ABSTRATA");
            Console.WriteLine("      • Palavra-chave: abstract");
            Console.WriteLine("      • NÃO pode ser instanciada");
            Console.WriteLine("      • Pode ter métodos abstratos E concretos");
            Console.WriteLine("      • Herança única\n");
            Console.WriteLine("   2. INTERFACE");
            Console.WriteLine("      • Contrato PURO");
            Console.WriteLine("      • Só definições (até C# 8.0)");
            Console.WriteLine("      • Implementação múltipla\n");
            
            Console.WriteLine("─".PadRight(65, '─') + "\n");
            Console.WriteLine("PARTE 1: CLASSE ABSTRATA\n");
            
            // ❌ NÃO funciona: Forma forma = new Forma();
            
            Circulo circulo = new Circulo { Nome = "Círculo", Raio = 5 };
            Retangulo retangulo = new Retangulo 
            { 
                Nome = "Retângulo", 
                Largura = 4, 
                Altura = 6 
            };
            
            Console.WriteLine("Formas criadas:");
            circulo.Informar();
            Console.WriteLine($"Área: {circulo.CalcularArea():F2}\n");
            
            retangulo.Informar();
            Console.WriteLine($"Área: {retangulo.CalcularArea():F2}\n");
            
            Console.WriteLine("─".PadRight(65, '─') + "\n");
            Console.WriteLine("PARTE 2: INTERFACE\n");
            
            Passaro passaro = new Passaro { Nome = "Águia" };
            Aviao aviao = new Aviao { Modelo = "Boeing 737" };
            Pato pato = new Pato { Nome = "Donald" };
            
            List<IVoador> voadores = new List<IVoador> { passaro, aviao, pato };
            
            Console.WriteLine("Todos implementam IVoador:\n");
            foreach (var voador in voadores)
            {
                voador.Voar();
            }
            
            Console.WriteLine("\nPato implementa MÚLTIPLAS interfaces:");
            if (pato is INadador nadador)
            {
                nadador.Nadar();
            }
            
            Console.WriteLine("\n─".PadRight(65, '─') + "\n");
            Console.WriteLine("💡 DIFERENÇA:\n");
            Console.WriteLine("   • Abstract = relacionamento 'É UM'");
            Console.WriteLine("   • Interface = capacidade 'PODE FAZER'\n");
        }
    }
}