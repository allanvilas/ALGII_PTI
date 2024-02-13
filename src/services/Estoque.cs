



using System.Data;

namespace PTI;

public class Estoque
{
    // Pattern: Singleton
    public static Estoque Instancia {get; private set;} = new Estoque();
    private Estoque(){}
    //    --
    
    // Controla o produto cadastro no sistema.
    public Dictionary<int,Produto> Produtos {get; private set;} = new Dictionary<int,Produto>{};
    
    // Controla a quantidade de estoque de cada produto no sistema.
    // Implementação:
    // KeyValuePair< IdProduto,Quantidade em estoque >
    private Dictionary<int,int> EstoqueProdutos = new Dictionary<int,int> {};
    public void AdicionaProduto(Produto produto)
    {
        int NovoId = Produtos.Count + 1;

        Produtos.Add(NovoId,produto);
        EstoqueProdutos.Add(NovoId,0);
    }

    public void RemoverProduto(int idProduto)
    {
        Produtos.Remove(idProduto);
        EstoqueProdutos.Remove(idProduto);
    }

    /* 
        Caso fosse necessário escalar o software a função abaixo deverá ser refatorada        
    */
    public int EncontrarIdProdutoPeloNome(string NomeProcura)
    {   
        foreach(var produto in Produtos){
            if(produto.Value.Nome == NomeProcura)
            {
                return produto.Key;
            }
        }
        return -1;
    }

    public void EntradaEstoque(int indiceProduto, int quantidade)
    {
        if(!Produtos.ContainsKey(indiceProduto)){throw new IndexOutOfRangeException("Esse indice de produto não existe!");}
        EstoqueProdutos[indiceProduto] += quantidade;
    }

    public int ChecaEstoqueProduto(int indiceProduto)
    {
        if(!Produtos.ContainsKey(indiceProduto)){throw new IndexOutOfRangeException("Esse indice de produto não existe!");}
        return EstoqueProdutos[indiceProduto];
    }

    public void SaidaEstoque(int indiceProduto, int quantidadeSaida)
    {
        if(!Produtos.ContainsKey(indiceProduto)){throw new IndexOutOfRangeException("Esse indice de produto não existe!");}
        if(EstoqueProdutos[indiceProduto] - quantidadeSaida < 0){throw new ConstraintException("Quantidade de saída errada.");}
        else{EstoqueProdutos[indiceProduto] -= quantidadeSaida;}
    }
}
