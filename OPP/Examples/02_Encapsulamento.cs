namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Encapsulamento
    // ============================================
    // Proteger dados internos com modificadores de acesso
    // Expõe apenas o necessário com métodos públicos
    
    public class ContaBancaria
    {
        // PRIVATE = só acessível DENTRO da classe
        private decimal saldo;
        private string senha;
        
        // PUBLIC = qualquer um pode ver/acessar
        public string Titular { get; set; }
        public string NumeroConta { get; set; }
        
        // INTERNAL = acessível no mesmo projeto
        internal int codigoInterno;
        
        // PROTECTED = classe e classes filhas
        protected DateTime dataCriacao;
        
        // Propriedade só para LEITURA
        public decimal Saldo => saldo;
        
        public ContaBancaria(string titular, string senha)
        {
            Titular = titular;
            this.senha = senha;
            saldo = 0;
            NumeroConta = Guid.NewGuid().ToString().Substring(0, 8);
            codigoInterno = 12345;
            dataCriacao = DateTime.Now;
        }
        
        // MÉTODO PÚBLICO = interface de acesso
        public bool Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("❌ Valor inválido!");
                return false;
            }
            
            saldo += valor; // Só aqui conseguimos modificar o saldo!
            Console.WriteLine($"✅ Deposito de R$ {valor:F2} realizado!");
            return true;
        }
        
        public bool Sacar(decimal valor, string senhaFornecida)
        {
            if (senhaFornecida != senha)
            {
                Console.WriteLine("❌ Senha incorreta!");
                return false;
            }
            
            if (valor > saldo)
            {
                Console.WriteLine("❌ Saldo insuficiente!");
                return false;
            }
            
            saldo -= valor;
            Console.WriteLine($"✅ Saque de R$ {valor:F2} realizado!");
            return true;
        }
    }
    
    // CLASSE FILHA - herda de ContaBancaria
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titular, string senha) : base(titular, senha)
        {
        }
        
        public void MostrarDataCriacao()
        {
            // PROTECTED é acessível aqui!
            Console.WriteLine($"Data criação: {dataCriacao:dd/MM/yyyy}");
        }
    }
    
    public static class EncapsulamentoExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    ENCAPSULAMENTO                          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("🔒 O QUE É?\n");
            Console.WriteLine("   Proteger dados internos controlando acesso através");
            Console.WriteLine("   de modificadores de acesso\n");
            
            Console.WriteLine("📋 MODIFICADORES DE ACESSO:\n");
            Console.WriteLine("   • PUBLIC    = Qualquer um pode acessar");
            Console.WriteLine("   • PRIVATE   = Só dentro da própria classe");
            Console.WriteLine("   • PROTECTED = Classe e classes filhas");
            Console.WriteLine("   • INTERNAL  = Só no mesmo projeto\n");
            
            ContaBancaria conta = new ContaBancaria("João Silva", "1234");
            
            Console.WriteLine("Tentando acessar PRIVATE:");
            Console.WriteLine($"Saldo atual: R$ {conta.Saldo:F2}\n");
            
            Console.WriteLine("Operações CONTROLADAS:");
            conta.Depositar(1000);
            conta.Sacar(200, "1234");  // Senha correta
            conta.Sacar(500, "errada"); // Senha errada
            
            Console.WriteLine("\n" + new string('─', 65) + "\n");
            
            Console.WriteLine("PROTECTED em ação:");
            ContaPoupanca poupanca = new ContaPoupanca("Maria", "5678");
            poupanca.MostrarDataCriacao(); // Acessa dataCriacao PROTECTED
            
            Console.WriteLine("\n💡 NÃO podemos: conta.saldo = 999999 ❌");
            Console.WriteLine("   Saldo é PRIVATE - só via métodos!\n");
        }
    }
}