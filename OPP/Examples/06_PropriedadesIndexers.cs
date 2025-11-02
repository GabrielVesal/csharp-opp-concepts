namespace OPP.Examples
{
    // ============================================
    // CONCEITO: Propriedades e Indexers
    // ============================================
    
    public class Produto
    {
        private decimal preco;
        
        public string Nome { get; set; }
        
        // Propriedade com LÓGICA
        public decimal Preco
        {
            get => preco;
            set => preco = value > 0 ? value : 0;
        }
        
        // Propriedade calculada (SÓ LEITURA)
        public string InfoCompleta => $"{Nome} - R$ {Preco:F2}";
    }
    
    // INDEXER - acessar como array
    public class Turma
    {
        private List<string> alunos = new List<string>();
        
        // INDEXER com int
        public string this[int index]
        {
            get => alunos[index];
            set => alunos[index] = value;
        }
        
        // INDEXER com string
        public int this[string nome]
        {
            get => alunos.IndexOf(nome);
        }
        
        public void AdicionarAluno(string nome)
        {
            alunos.Add(nome);
        }
        
        public int Total => alunos.Count;
    }
    
    public class Matriz
    {
        private int[,] dados;
        public int Linhas { get; private set; }
        public int Colunas { get; private set; }
        
        public Matriz(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            dados = new int[linhas, colunas];
        }
        
        // INDEXER BIDIMENSIONAL
        public int this[int l, int c]
        {
            get => dados[l, c];
            set => dados[l, c] = value;
        }
    }
    
    public static class PropriedadesIndexersExample
    {
        public static void Executar()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            PROPRIEDADES E INDEXERS                        ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝\n");
            
            Console.WriteLine("Propriedades customizadas:\n");
            
            Produto p = new Produto { Nome = "Notebook", Preco = 5000 };
            Console.WriteLine(p.InfoCompleta);
            
            p.Preco = -100; // Validação impede
            Console.WriteLine(p.InfoCompleta);
            
            Console.WriteLine("\n" + new string('─', 65) + "\n");
            
            Console.WriteLine("INDEXER - Acessar como array:\n");
            
            Turma turma = new Turma();
            turma.AdicionarAluno("João");
            turma.AdicionarAluno("Maria");
            turma.AdicionarAluno("Pedro");
            
            Console.WriteLine($"Aluno [0]: {turma[0]}");
            Console.WriteLine($"Aluno [1]: {turma[1]}");
            Console.WriteLine($"Index de 'Maria': {turma["Maria"]}");
            
            turma[0] = "João Silva"; // Modifica via indexer
            Console.WriteLine($"Aluno [0]: {turma[0]}");
            
            Console.WriteLine("\n" + new string('─', 65) + "\n");
            
            Console.WriteLine("INDEXER BIDIMENSIONAL:\n");
            
            Matriz m = new Matriz(3, 4);
            m[0, 0] = 11; m[0, 1] = 12; m[0, 2] = 13; m[0, 3] = 14;
            m[1, 0] = 21; m[1, 1] = 22; m[1, 2] = 23; m[1, 3] = 24;
            m[2, 0] = 31; m[2, 1] = 32; m[2, 2] = 33; m[2, 3] = 34;
            
            Console.WriteLine($"matriz[1,2] = {m[1, 2]}");
            Console.WriteLine($"matriz[2,3] = {m[2, 3]}");
            
            Console.WriteLine("\n💡 Indexer = Acesso intuitivo como arrays!");
        }
    }
}
