namespace BankSystem;

public class Pessoa
{
    public Pessoa(string nome, int idade, string documento)
    {
        Nome = nome;
        Idade = idade;
        Documento = documento;
    }
    
    public string Nome{get;set;}
    public int Idade{get;set;}
    public string Documento{get;set;}
}