namespace PTI;

public class ControleEstoque
{
    private readonly string? Menu;

    public ControleEstoque(){
        // Construção menu        
        Menu += "[1] Novo\n";
        Menu += "[2] Listar Produtos\n";
        Menu += "[3] Remover Produtos\n";
        Menu += "[4] Entrada Estoque\n";
        Menu += "[5] Saída Estoque\n";
        Menu += "[0] Sair\n";

        
    }

}
