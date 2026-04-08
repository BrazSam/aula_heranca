namespace ClassesHerança;

public class Funcionario : Pessoa
{
    public string Matricula {get; set;}
    public decimal Salario {get; set;}

    //construtor com parametros OPCIONAIS para facilitar a criação de objetos Funcionario
    //os parametros do construtor de Funcionario incluem os parametros da classe base Pessoa e os atributos da classe Funcionario
    public Funcionario(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0)
        : base(nome, cpf, rg, idade, endereco, numero, complemento)
        {
            //atribui os valores dos parametros aos atributos da classe Funcionario
            Matricula = matricula;
            Salario = salario;
        }
}