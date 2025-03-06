using Barbearia;

while (true)
{
    Console.WriteLine(" == Menu Barbearia VH");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Cadastrar Serviço");
    Console.WriteLine("3 - Reservar Horario");
    Console.WriteLine("4 - Listar Reservas");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("6 - Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Clientes.CadastarCliente(nome, telefone);
            break;

        case "2":
            Console.WriteLine("Nome do serviço: ");
            string nomeServico = Console.ReadLine();
            Console.WriteLine("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Duração em minutos: ");
            int duracao = int.Parse(Console.ReadLine());
            Servicos.CadastrarServico(nomeServico, preco, duracao);
            break;

        case "3":
            Console.WriteLine("ID do Cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("ID do Serviço: ");
            int idServico = int.Parse(Console.ReadLine());

            Console.WriteLine("Data e Hora (yyyy-MM-dd HH:mm): ");
            DateTime dataHora = DateTime.Parse(Console.ReadLine());

            Reserva.ReservarHorario(idCliente, idServico, dataHora);
            break;

        case "4":
            Listar.ListarReservas();
            break;

        case "5":
            ListarCliente.ListarClientes();
            break;

        case "6":
            return;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
