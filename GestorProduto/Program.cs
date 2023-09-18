namespace NomeDoSeuNamespace
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            ExibirOpcoesDoMenu();
        }

        static void ExibirOpcoesDoMenu()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Editar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Sair");

                Console.Write("\nDigite a sua opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        RemoverProduto();
                        break;
                    case 3:
                        EditarProduto();
                        break;
                    case 4:
                        ListarProdutos();
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        //static void CadastrarProduto()
        //{
        //    Console.Write("\nDigite o nome do produto: ");
        //    string nome = Console.ReadLine();

        //    Console.Write("\nDigite o ID do produto: ");
        //    int id = int.Parse(Console.ReadLine());

        //    Produto produto = new Produto(id, nome);
        //    produtos.Add(produto);

        //    Console.WriteLine("\nProduto cadastrado com sucesso!");

        //}

        static void CadastrarProduto()
        {

            Console.Write("\nDigite o ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            if (produtos.Any(p => p.Id == id))
            {
                Console.WriteLine("O ID já existe.");
                return;
            }

            Console.Write("\nDigite o nome do produto: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O Nome não pode conter apenas espaços vazios.");
                return;
            }

            Produto produto = new Produto(id, nome);
            produtos.Add(produto);

            Console.WriteLine("\nProduto cadastrado com sucesso!");

        }

        static void RemoverProduto()
        {
            Console.Write("\nDigite o ID do produto que deseja remover: ");
            int idRemover = int.Parse(Console.ReadLine());

            Produto produtoRemover = null;
            foreach (Produto produto in produtos)
            {
                if (produto.Id == idRemover)
                {
                    produtoRemover = produto;
                    break;
                }
            }

            if (produtoRemover != null)
            {
                produtos.Remove(produtoRemover);
                Console.WriteLine("\nProduto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void EditarProduto()
        {
            Console.Write("\nDigite o ID do produto que deseja editar:");
            int idEditar = int.Parse(Console.ReadLine());

            Produto produtoEditar = null;
            foreach (Produto produto in produtos)
            {
                if (produto.Id == idEditar)
                {
                    produtoEditar = produto;
                    break;
                }
            }

            if (produtoEditar != null)
            {
                Console.Write("\nDigite o novo nome do produto: ");
                string novoNome = Console.ReadLine();

                produtoEditar.Nome = novoNome;
                Console.WriteLine("\nProduto editado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
        }

        static void ListarProdutos()
        {
            Console.WriteLine("\nLista de Produtos:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"\nNome: {produto.Nome}");
                Console.WriteLine($"ID: {produto.Id}");
            }
        }

    }
}

