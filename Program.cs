namespace projetocrud
{
    class Program
    {
        static ClienteRepositorio repositorio = new ClienteRepositorio();


        static void Main(string[] args)
        {
            string OpcaoCadastro = Opcoes();

            while (OpcaoCadastro.ToUpper() != "X")
            {
                switch (OpcaoCadastro)
                {

                    case "1":
                        ListarClientes();

                        break;

                    case "2":
                        InserirCliente();

                        break;

                    case "3":
                        AtualizarCliente();

                        break;

                    case "4":
                        ExcluirCliente();

                        break;

                    case "5":
                        VisualizarCliente();
                        break;

                    case "L":
                        Console.Clear();

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                System.Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                Console.Clear();

                OpcaoCadastro = Opcoes();
            }

            System.Console.WriteLine("Agradecemos por usar os nossos serviços");
            Console.ReadLine();

        }

        private static void ListarClientes()
        {
            System.Console.WriteLine("Listar Clientes");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhum cliente cadastrado");
            }
            else
            {
                foreach (var cliente in lista)
                {
                    System.Console.WriteLine("ID {0}: - {1}. {2}", cliente.RetornarId(), cliente.RetornarNomeCompleto(), cliente.Excluido ? "Excluído" : "");
                }
            }


        }

        private static void InserirCliente()

        {
            Cliente cliente = new Cliente();

            System.Console.WriteLine("Inserir dados do Cliente");

            System.Console.WriteLine("Digite o Nome Completo: ");
            cliente.NomeCompleto = Console.ReadLine();

            System.Console.WriteLine("Informe o CPF: ");
            cliente.CPF = Console.ReadLine();

            System.Console.WriteLine("Informe a Data de Nascimento: ");
            cliente.DataDeNascimento = Console.ReadLine();

            System.Console.WriteLine("Informe a renda mensal do cliente: ");
            cliente.RendaMensal = Double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Insira o endereço completo: ");
            cliente.Endereco = Console.ReadLine();

            System.Console.WriteLine("Informe os telefones de contato do cliente: ");
            cliente.Endereco = Console.ReadLine();

            System.Console.WriteLine("Digite o e-mail do cliente: ");
            cliente.Email = Console.ReadLine();

            repositorio.Inserir(cliente);


        }

        private static void AtualizarCliente()

        {
            Cliente cliente = new Cliente();

            System.Console.WriteLine("Digite o ID do cliente que você deseja alterar: ");
            repositorio.RetornarPorId(Int32.Parse(Console.ReadLine()!));

            System.Console.WriteLine("Digite o Nome Completo: ");
            cliente.NomeCompleto = Console.ReadLine();

            System.Console.WriteLine("Informe o CPF: ");
            cliente.CPF = Console.ReadLine();

            System.Console.WriteLine("Informe a Data de Nascimento: ");
            cliente.DataDeNascimento = Console.ReadLine();

            System.Console.WriteLine("Informe a renda mensal do cliente: ");
            cliente.RendaMensal = Double.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Insira o endereço completo: ");
            cliente.Endereco = Console.ReadLine();

            System.Console.WriteLine("Informe os telefones de contato do cliente: ");
            cliente.Endereco = Console.ReadLine();

            System.Console.WriteLine("Digite o e-mail do cliente: ");
            cliente.Email = Console.ReadLine();

            repositorio.Atualizar(cliente.id, cliente);

        }

        public static void ExcluirCliente()
        {

            System.Console.WriteLine("Digite o ID do cliente que você deseja excluir do cadastro: ");
            int indicecliente = Int32.Parse(Console.ReadLine()!);

            var cliente = repositorio.RetornarPorId(indicecliente);

            repositorio.Excluir(indicecliente, cliente);
        }

        public static void VisualizarCliente()
        {
         

            System.Console.WriteLine("Digite o ID do cliente para visualizar o seu cadastro: ");
            int indicecliente = Int32.Parse(Console.ReadLine()!);

            var cliente = repositorio.RetornarPorId(indicecliente);

           System.Console.WriteLine($"{indicecliente}: ");
           System.Console.WriteLine("ID {0}: - {1}", cliente.RetornarId(), cliente.RetornarNomeCompleto());
        }


        private static string Opcoes()
        {
            System.Console.WriteLine("Sistema de Cadastro de Clientes");
            System.Console.WriteLine("Informe a opção desejada: ");

            System.Console.WriteLine("1 - Listar Clientes");
            System.Console.WriteLine("2 - Inserir novo Cliente");
            System.Console.WriteLine("3 - Atualizar informações do Cliente");
            System.Console.WriteLine("4 - Excluir Cliente do Cadastro");
            System.Console.WriteLine("5 - Visualizar Cliente");
            System.Console.WriteLine("L - Limpar tela");
            System.Console.WriteLine("X - Sair");

            string OpcaoCadastro = Console.ReadLine()!.ToUpper();
            return OpcaoCadastro;

        }
    }
}
