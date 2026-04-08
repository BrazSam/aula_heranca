namespace ClassesHerança;

public class Pessoa
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Rg {get; set;}
    public string Idade {get; set;}
    public Logradouro Endereco {get; set;} //ASSOCIAÇÃO com a classe Logradouro
    public string Numero {get; set;}
    public string Complemento {get; set;}


//construtor com parametros OPCIONAIS para facilitar a criação de objetos Pessoa
    public Pessoa(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "")
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Idade = idade;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
        }
}