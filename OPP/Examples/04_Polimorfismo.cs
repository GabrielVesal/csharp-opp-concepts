namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Polimorfismo
    // ============================================
    // "Múltiplas formas" - objetos diferentes,
    // mesma interface, comportamentos diferentes
    
    public class Funcionario
    {
        public string Nome { get; set; }
        
        public virtual void Trabalhar()
        {
            Console.WriteLine($"{Nome} está trabalhando...");
        }
    }
    
    public class Gerente : Funcionario
    {
        // SOBRESCRITA (Override) - Runtime
        public override void Trabalhar()
        {
            Console.WriteLine($"👔 {Nome} está gerenciando a equipe!");
        }
    }
    
    public class Vendedor : Funcionario
    {
        public override void Trabalhar()
        {
            Console.WriteLine($"💰 {Nome} está vendendo produtos!");
        }
    }
    
    public class Programador : Funcionario
    {
        public override void Trabalhar()
        {
            Console.WriteLine($"💻 {Nome} está codando em C#!");
        }
    }
    
    // ============================================
    // SOBRECARGA (Overload)
    // ============================================
    public class Calculadora
    {
        // Mesmo método, parâmetros diferentes
        public int Somar(int a, int b)
        {
            Console.WriteLine("Somando 2 números inteiros");
            return a + b;
        }
        
        public int Somar(int a, int b, int c)
        {
            Console.WriteLine("Somando 3 números inteiros");
            return a + b + c;
        }
        
        public double Somar(double a, double b)
        {
            Console.WriteLine("Somando 2 números decimais");
            return a + b;
        }
    }
    
    public static class PolimorfismoExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    POLIMORFISMO                          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("🎭 O QUE É?\n");
            Console.WriteLine("   Capacidade de tratar objetos diferentes pela mesma");
            Console.WriteLine("   interface, cada um respondendo de forma específica\n");
            
            Console.WriteLine("📋 TIPOS DE POLIMORFISMO:\n");
            Console.WriteLine("   1. SOBRESCRITA (Override) - Runtime");
            Console.WriteLine("      • virtual na base + override na derivada");
            Console.WriteLine("      • Decisão em tempo de execução\n");
            Console.WriteLine("   2. SOBRECARGA (Overload) - Compile-time");
            Console.WriteLine("      • Mesmo nome, parâmetros diferentes");
            Console.WriteLine("      • Decisão em tempo de compilação\n");
            
            Console.WriteLine("─".PadRight(65, '─') + "\n");
            Console.WriteLine("PARTE 1: SOBRESCRITA\n");
            
            Gerente gerente = new Gerente { Nome = "Carlos" };
            Vendedor vendedor = new Vendedor { Nome = "Ana" };
            Programador programador = new Programador { Nome = "Pedro" };
            
            // Lista POLIMÓRFICA
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                gerente, vendedor, programador
            };
            
            Console.WriteLine("Tratando TODOS como 'Funcionario':\n");
            foreach (var func in funcionarios)
            {
                func.Trabalhar(); // Cada um responde diferente! (Sobrescrita)
            }
            
            Console.WriteLine("\n─".PadRight(65, '─') + "\n");
            Console.WriteLine("PARTE 2: SOBRECARGA\n");
            
            Calculadora calc = new Calculadora();
            Console.WriteLine($"Somar(5, 3) = {calc.Somar(5, 3)}\n");
            Console.WriteLine($"Somar(1, 2, 3) = {calc.Somar(1, 2, 3)}\n");
            Console.WriteLine($"Somar(5.5, 3.5) = {calc.Somar(5.5, 3.5)}\n");
            
            Console.WriteLine("💡 Polimorfismo = Flexibilidade máxima!");
        }
    }
}