namespace PTI;

public static class ControleEstoque
{
    private static readonly string? Menu;

    private static readonly int[] PossiveisOpcoes = {0,1,2,3,4,5};

    static ControleEstoque(){
        // Construção menu        
        Menu += "----------[Fim operação]----------\n";
        Menu += "----------[Inicio operação]----------\n";
        Menu += "[1] Novo\n";
        Menu += "[2] Listar Produtos\n";
        Menu += "[3] Remover Produtos\n";
        Menu += "[4] Entrada Estoque\n";
        Menu += "[5] Saída Estoque\n";
        Menu += "[0] Sair\n";
        
    }
    public static void MostraMenu(int opcao = 999){
        
              
        if(opcao == 0){Environment.Exit(1);}

        try
        {
            Console.Write($"{Menu}\nEscolha a opção\n> ");
            opcao = Convert.ToInt16(Console.ReadLine());
            
            if(!PossiveisOpcoes.Contains(opcao)){throw new IndexOutOfRangeException("Você escolheu uma opção não possível, tente novamente.");};

            MostraMenu(opcao);
        }
        catch (System.Exception Erro)
        {   
            Console.Write($"Não foi possível executar a operação, tente novamente\n Erro:{Erro.Message}\nAperte enter para continuar...\n");            
            Console.ReadLine();
            MostraMenu(opcao);
            throw;
        }
    }
}
