namespace BankSystem;

public class Conta
{
    public List<Cliente> clientes = new List<Cliente>();
    public int indice { get; set; }

    //Operações da conta relacionada ao cliente
    public void AdicionarCliente(Cliente cliente)
    {
        Random randNum = new Random();
        int numConta = randNum.Next(0, 100);
        indice++;
        cliente.Id = indice;
        cliente.Numconta = numConta;
        clientes.Add(cliente);
        
        Console.WriteLine("Cliente adicionado com sucesso!");
        
    }

    public void ListarClientes()
    {
        foreach (var cli in clientes)
        {
            cli.Apresentar();
        }
    }

    public void RemoverCliente(int id)
    {
        if (clientes.Any(cli => cli.Id == id))
        {
            foreach (var cli in clientes)
            {
                if (cli.Id == id)
                {
                    clientes.Remove(cli);
                    Console.WriteLine("Cliente removido com sucesso!");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }
    
    //Operações Bancárias

    public void Depositar(Double valor, int numConta)
    {
        if (clientes.Any(cli => cli.Numconta == numConta))
        {
            foreach (var cli in clientes)
            {
                if (cli.Numconta == numConta)
                {
                    cli.Saldo = cli.Saldo + valor;
                    Console.WriteLine("Saldo atualizado com sucesso!");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }
    
    public void Sacar(Double valor, int numConta)
    {
        if (clientes.Any(cli => cli.Numconta == numConta))
        {
            foreach (var cli in clientes)
            {
                if (cli.Numconta == numConta)
                {
                    cli.Saldo = cli.Saldo - valor;
                    Console.WriteLine("Saldo atualizado com sucesso!");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }

    public void ConsultarSaldo(int numConta)
    {
        if (clientes.Any(cli => cli.Numconta == numConta))
        {
            foreach (var cli in clientes)
            {
                if (cli.Numconta == numConta)
                {
                    cli.ApresentarSaldo();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }
}