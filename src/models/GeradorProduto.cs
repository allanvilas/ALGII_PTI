using System.Runtime.InteropServices;

namespace PTI;

public class GeradorProduto
{
    private readonly IRecebeProduto _RecebeProduto;

    public GeradorProduto(IRecebeProduto recebeProduto){
        _RecebeProduto = recebeProduto;
    }
    
    public Produto GeraProduto(){

        return new Produto(
            CadastraNome(_RecebeProduto.ReadLine().Trim()),
            CadastraPreco(_RecebeProduto.ReadLine().Trim()),
            CadastraMarca(_RecebeProduto.ReadLine().Trim()),
            CadastraPeso(_RecebeProduto.ReadLine().Trim()),
            CadastraAnoLancamento(_RecebeProduto.ReadLine().Trim()),
            CadastraDiasGarantia(_RecebeProduto.ReadLine().Trim())
        );
    }

    public string CadastraNome(string nome)
    {
        if (nome is null) { throw new NullReferenceException("CadastraNome: valor de parâmetro nulo."); }
        string? EntradaNome = nome.Trim();
        string Nome = EntradaNome != null ? EntradaNome.Trim() : string.Empty;

        return Nome;
    }
    public decimal CadastraPreco(string preco)
    {
        decimal ConvertePreco = Convert.ToDecimal(preco);
        decimal Preco = ConvertePreco > 0.00m ? ConvertePreco : throw new ArgumentException("CadastraPreco: Valor não pode ser negativo.");
        return Preco;
    }
    public string CadastraMarca(string marca)
    {
        if (marca is null) { throw new NullReferenceException("CadastraMarca: valor de parâmetro nulo."); }
        string? EntradaMarca = _RecebeProduto.ReadLine().Trim();
        string Marca = EntradaMarca != null ? EntradaMarca.Trim() : string.Empty;

        return Marca;
    }
    public double CadastraPeso(string preco)
    {
        double ConvertePeso = Convert.ToDouble(preco);
        double Peso = ConvertePeso > 0.0 ? ConvertePeso : throw new ArgumentException("CadastraPeso: Valor não pode ser negativo.");
        
        return Peso;
    }
    public int CadastraAnoLancamento(string anoLancamento)
    {
        int ConverteAnoLancamento = Convert.ToInt16(anoLancamento);
        int AnoLancamento = ConverteAnoLancamento > 0 ? ConverteAnoLancamento : throw new ArgumentException("CadastraAnoLancamento: Valor não pode ser negativo.");

        return AnoLancamento;
    }
    public int CadastraDiasGarantia(string diasGarantia)
    {
        int ConverteDiasGarantia = Convert.ToInt16(diasGarantia);
        int DiasGarantia = ConverteDiasGarantia > 0 ? ConverteDiasGarantia : throw new ArgumentException("CadastraDiasGarantia: Valor não pode ser negativo.");
        
        return DiasGarantia;
    }
}
