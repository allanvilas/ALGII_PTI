namespace PTI_ALG_PROG_II;

public class ProdutoTestes
{
    [Fact]
    public void TesteInstanciaProduto()
    {
        //Arrange,Act
        // Nome,preço,quantidade,peso,anoLancamento,diasGarantia
        Produto mouse = new("Mouse Razer Naga Hex",599.9m,"Razer",500,2023,190);
        //Assert
        Assert.Equal("Mouse Razer Naga Hex",mouse.Nome);
        Assert.Equal(599.9m,mouse.Preco);
        Assert.Equal("Razer",mouse.Marca);
        Assert.Equal(500,mouse.Peso);
        Assert.Equal(2023,mouse.AnoLancamento);
        Assert.Equal(190,mouse.DiasGarantia);
    }
}
