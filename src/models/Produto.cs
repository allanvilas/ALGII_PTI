namespace PTI;

public struct Produto
{
    public string Nome { get; }
    public decimal Preco { get; }
    public int Quantidade { get; }
    public int Peso { get; }
    public int AnoLancamento { get; }
    public int DiasGarantia { get; }

    public Produto(string nome, decimal preco, int quantidade, int peso, int anoLancamento, int diasGarantia)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
        Peso = peso;
        AnoLancamento = anoLancamento;
        DiasGarantia = diasGarantia;
    }
}