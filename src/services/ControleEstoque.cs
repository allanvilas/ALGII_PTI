namespace PTI;

public static class ControleEstoque
{
    private static readonly Dictionary<int,string> 
    OpcoesMenu = new Dictionary<int, string> 
        {
            {0,"Sair"},
            {1,"Novo"},
            {2,"Listar Produtos"},
            {3,"Remover Produtos"},
            {4,"Entrada Estoque"},
            {5,"Saída Estoque"}
        };
    private static void constructMenu(){

        // Demais Opções
        foreach(KeyValuePair<int,string> Entrie in OpcoesMenu){
            if(Entrie.Key > 0){
                Console.WriteLine($"[{Entrie.Key}] {Entrie.Value}");
            }
        }

        // Ultima Opcção
        Console.WriteLine($"[0] {OpcoesMenu[0]}");

        // Solicitação final de entrada de opção
        // Manual
        Console.Write("Digite a opção desejada:\n> ");
    }
    public static void MostraMenu(int opcao = 999){
                      
        if(opcao == 0){Environment.Exit(1);}

        try
        {            
            constructMenu();
            opcao = Convert.ToInt16(Console.ReadLine());

            // Joga nova exception se o a opção escolhida não existe dentro da array de opções possíveis
            if(!OpcoesMenu.ContainsKey(opcao)){throw new IndexOutOfRangeException("Você escolheu uma opção não possível, tente novamente.");};

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


