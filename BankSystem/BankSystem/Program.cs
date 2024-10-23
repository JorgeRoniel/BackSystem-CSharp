
using BankSystem;

bool sair = false;
var acc = new Conta();

while (!sair)
{
    Console.Clear();
    Console.WriteLine("===== MENU DO SISTEMA BANCÁRIO =====");
    Console.WriteLine("1 - Criar Conta");
    Console.WriteLine("2 - Listar Contas");
    Console.WriteLine("3 - Remover Conta");
    Console.WriteLine("4 - Depositar");
    Console.WriteLine("5 - Sacar");
    Console.WriteLine("6 - Consultar Saldo");
    Console.WriteLine("7 - Sair");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero do seu documento: ");
            var doc = Console.ReadLine();
            Console.WriteLine("Digite o seu saldo: ");
            var saldo = Convert.ToDouble(Console.ReadLine());

            var cliente = new Cliente(nome, idade, doc, saldo);
            acc.AdicionarCliente(cliente);
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            acc.ListarClientes();
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Digite o seu ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            
            acc.RemoverCliente(id);
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("Digite a quantia que voce deseja depositar: ");
            var quant = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o numero da sua conta: ");
            var numConta = Convert.ToInt32(Console.ReadLine());
            
            acc.Depositar(quant, numConta);
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine("Digite a quantia que voce deseja sacar: ");
            var quant_saque = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe o numero da sua conta: ");
            var numConta_saque = Convert.ToInt32(Console.ReadLine());
            
            acc.Sacar(quant_saque, numConta_saque);
            Console.ReadKey();
            break;
        case "6":
            Console.WriteLine("Informe o numero da sua conta: ");
            var numConta_con = Convert.ToInt32(Console.ReadLine());
            
            acc.ConsultarSaldo(numConta_con);
            Console.ReadKey();
            break;
        case "7":
            sair = true;
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            break;
    }
}
