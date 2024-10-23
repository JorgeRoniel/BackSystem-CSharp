namespace BankSystem;

public class Cliente : Pessoa
{
    public Cliente(string nome, int idade, string documento, double saldo) : base(nome, idade,
        documento)
    {
        Saldo = saldo;
    }
    
    public int Id { get; set; }
    public double Saldo { get; set; }
    public int Numconta { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Conta numero {Numconta} \n Id: {Id} \n Nome: {Nome} \n Idade: {Idade} \n");
    }

    public void ApresentarSaldo()
    {
        Console.WriteLine($"O saldo do cliente {Nome} é: \n {Saldo} \n");
    }
}