namespace tests;

public class EstoqueTestes
{    
    Estoque sut = Estoque.Instancia;

    [Fact]
    public void TesteCadastroProduto(){
        //Arrange
        Produto produtoTeste = new("Mouse Razer Naga Hex",599.9m,10,500,2023,190);
        int EstoqueContagem = sut.Produtos.Count;

        //Act
        sut.AdicionaProduto(produtoTeste);

        //Assert
        Assert.Equal(EstoqueContagem + 1, sut.Produtos.Count);
    }
    [Fact]
    public void TesteProcuraIdProduto(){
        //Arrange
        Produto produtoTeste = new("Mouse Razer Naga Hex",599.9m,10,500,2023,190);
        sut.AdicionaProduto(produtoTeste);
        
        //Act
        int idProduto = sut.EncontrarIdProdutoPeloNome("Mouse Razer Naga Hex");
        
        //Assert
        Assert.Equal(1,idProduto);
    }

    [Fact]
    public void TesteRemocaoProdutos(){
        //Arrange
        Produto produtoTeste = new("Mouse Razer Naga Hex",599.9m,10,500,2023,190);
        sut.AdicionaProduto(produtoTeste);
        int EstoqueContagem = sut.Produtos.Count;
        
        //Act
        int idProduto = sut.EncontrarIdProdutoPeloNome("Mouse Razer Naga Hex");
        sut.RemoverProduto(idProduto);

        //Assert
        Assert.Equal(EstoqueContagem - 1, sut.Produtos.Count);
    }

    [Fact]
    public void TesteEntradaEstoque(){
        //Arrange
        Produto produtoTeste = new("Mouse Razer Naga Hex",599.9m,10,500,2023,190);
        sut.AdicionaProduto(produtoTeste);
        int IndiceProduto = 1;
        int quantidade = 10;

        //Act
        sut.EntradaEstoque(IndiceProduto,quantidade);

        //Assert
        int quantidadeEstoque = sut.ChecaEstoqueProduto(IndiceProduto);
        Assert.Equal(quantidade,quantidadeEstoque);
    }

    [Fact]
    public void TesteSaidaEstoque(){
        //Arrange
        Produto produtoTeste = new("Mouse Razer Naga Hex",599.9m,10,500,2023,190);
        sut.AdicionaProduto(produtoTeste);
        int IndiceProduto = 1;
        int quantidadeEntrada = 10;
        int quantidadeSaida = 5;
        sut.EntradaEstoque(IndiceProduto,quantidadeEntrada);

        //Act
        sut.SaidaEstoque(IndiceProduto,quantidadeSaida);

        //Assert
        int quantidadeEstoque = sut.ChecaEstoqueProduto(IndiceProduto);
        Assert.Equal(quantidadeEntrada-quantidadeSaida,quantidadeEstoque);
    }
}