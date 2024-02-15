namespace PTI;

public struct Produto
{
    /*
        ::Disclaimer::
        Se necessário implementar funcionalidade de alteraçao de características de produtos
        é preciso refatorar as propriedades e adicionar setters além do construtor.

        Motivo>>
        Funcionalidade não foi incluida nos requisitos do projeto.
    */
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public string Marca { get; private set; }
    public double Peso { get; private set; }
    public int AnoLancamento { get; private set; }
    public int DiasGarantia { get; private set; }
    public bool Habilitado { get; private set; }
    public Produto(string nome, decimal preco, string marca, int peso, int anoLancamento, int diasGarantia)
    {
        Nome = nome;
        Preco = preco;
        Marca = marca;
        Peso = peso;
        AnoLancamento = anoLancamento;
        DiasGarantia = diasGarantia;
        ProdutoPodeSerHabilitado();
    }

    public Produto()
    {
        Console.WriteLine("---- Inicio Cadastro Produto ----");
        try
        {
            CadastraNome();
            CadastraPreco();
            CadastraMarca();
            CadastraPeso();
            CadastraAnoLancamento();
            CadastraDiasGarantia();
            ProdutoPodeSerHabilitado();
        }
        catch (FormatException Erro)
        {

            throw;
        }
        catch (System.Exception)
        {

            throw;
        }
        Console.WriteLine("---- Fim Cadastro Produto ----");
    }
    private void ProdutoPodeSerHabilitado()
    {
        bool ChecaNome = false;
        bool ChecaPreco = false;
        bool ChecaMarca = false;
        bool ChecaPeso = false;
        bool ChecaAnoLancamento = false;
        bool ChecaDiasGarantia = false;

        if (Nome is not null && Nome != "") { Console.WriteLine("[O] Nome é valido"); ChecaNome = true; } else { Console.WriteLine("[X] Nome é invalido"); ChecaNome = false; }
        if (Preco > 0.00m) { Console.WriteLine("[O] Preco é valido"); ChecaPreco = true; } else { Console.WriteLine("[X] Preco é invalido"); ChecaPreco = false; }
        if (Marca is not null && Marca != "") { Console.WriteLine("[O] Marca é valido"); ChecaMarca = true; } else { Console.WriteLine("[X] Marca é invalido"); ChecaMarca = false; }
        if (Peso > 0.0) { Console.WriteLine("[O] Peso é valido"); ChecaPeso = true; } else { Console.WriteLine("[X] Peso é invalido"); ChecaPeso = false; }
        if (AnoLancamento > 0) { Console.WriteLine("[O] AnoLancamento é valido"); ChecaAnoLancamento = true; } else { Console.WriteLine("[X] ChecaAnoLancamento é invalido"); Habilitado = false; }
        if (DiasGarantia > 0) { Console.WriteLine("[O] DiasGarantia é valido"); ChecaDiasGarantia = true; } else { Console.WriteLine("[X] DiasGarantia é invalido"); ChecaDiasGarantia = false; }

        if (ChecaNome && ChecaPreco && ChecaMarca && ChecaPeso && ChecaAnoLancamento && ChecaDiasGarantia) { Habilitado = true; Console.WriteLine("Este produto está habilitado."); } else { Habilitado = false; Console.WriteLine("Este produto não está habilitado. há ajustes pendentes."); }
    }
    public void CadastraNome()
    {
        try
        {
            Console.Write("\nInsira o nome do produto:\n> ");
            string? EntradaNome = Console.ReadLine().Trim();
            Nome = EntradaNome != null ? EntradaNome.Trim() : string.Empty;
        }
        catch (Exception Erro)
        {
            if (Nome is null)
            {
                Console.WriteLine($"{Erro.Message}\n\n Parece que houve um erro, inserindo valor padrão no nome.");
                Nome = "Precisa ser alterado";
                Habilitado = false;
            }
            else
            {
                Console.WriteLine($"{Erro.Message}\n\n Parece que houve um erro no cadastro, Tente novamente");
            }
            throw;
        }
    }
    public void CadastraNome(string nome)
    {
        if (nome is null) { throw new NullReferenceException("CadastraNome: valor de parâmetro nulo."); }
        string? EntradaNome = nome.Trim();
        Nome = EntradaNome != null ? EntradaNome.Trim() : string.Empty;
    }
    public void CadastraPreco()
    {
        Console.Write("\nInsira o preço do produto (e.g 1.99):\n> ");
        decimal EntradaPreco = Convert.ToDecimal(Console.ReadLine());
        Preco = EntradaPreco > 0.00m ? EntradaPreco : throw new ArgumentException("CadastraPreco: Valor não pode ser negativo.");
    }
    public void CadastraPreco(decimal preco)
    {
        Preco = preco > 0.00m ? preco : throw new ArgumentException("CadastraPreco: Valor não pode ser negativo.");
    }
    public void CadastraMarca()
    {
        Console.Write("\nInsira o nome da marca:\n> ");
        string? EntradaMarca = Console.ReadLine().Trim();
        Marca = EntradaMarca != null ? EntradaMarca.Trim() : string.Empty;
    }
    public void CadastraMarca(string marca)
    {
        if (marca is null) { throw new NullReferenceException("CadastraMarca: valor de parâmetro nulo."); }
        string? EntradaMarca = Console.ReadLine().Trim();
        Marca = EntradaMarca != null ? EntradaMarca.Trim() : string.Empty;
    }
    public void CadastraPeso()
    {
        Console.Write("\nInsira o peso do produto (e.g 1Kg = 1.0 | 500g = 0.5):\n> ");
        double EntradaPeso = Convert.ToDouble(Console.ReadLine());
        Peso = EntradaPeso > 0.0 ? EntradaPeso : throw new ArgumentException("CadastraPeso: Valor não pode ser negativo.");
    }
    public void CadastraPeso(double preco)
    {
        Peso = preco > 0.0 ? preco : throw new ArgumentException("CadastraPeso: Valor não pode ser negativo.");
    }
    public void CadastraAnoLancamento()
    {
        Console.Write("\nInsira o ano de lancamento do produto:\n> ");
        int EntradaAno = Convert.ToInt16(Console.ReadLine());
        AnoLancamento = EntradaAno > 0 ? EntradaAno : throw new ArgumentException("CadastraAnoLancamento: Valor não pode ser negativo.");
    }
    public void CadastraAnoLancamento(int anoLancamento)
    {
        AnoLancamento = anoLancamento > 0 ? anoLancamento : throw new ArgumentException("CadastraAnoLancamento: Valor não pode ser negativo.");
    }
    public void CadastraDiasGarantia()
    {
        Console.Write("\nInsira a quantidade de dias de garantia do produto:\n> ");
        int EntradaGarantia = Convert.ToInt16(Console.ReadLine());
        DiasGarantia = EntradaGarantia > 0 ? EntradaGarantia : throw new ArgumentException("CadastraDiasGarantia: Valor não pode ser negativo.");
    }
    public void CadastraDiasGarantia(int anoLancamento)
    {
        DiasGarantia = anoLancamento > 0 ? anoLancamento : throw new ArgumentException("CadastraDiasGarantia: Valor não pode ser negativo.");
    }
}