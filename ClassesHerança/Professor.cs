namespace ClassesHerança;

public class Professor : Funcionario
{
    public string Titulacao {get; set;}
    public string AreaAtuacao {get; set;} 
    
    //construtor com parametros OPCIONAIS para facilitar a criação de objetos Professor
    //os parametros do construtor de Professor incluem os parametros da classe base Pessoa e os atributos

    public Professor(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "", string titulacao = "", string areaAtuacao = "")
        : base(nome, cpf, rg, idade, endereco, numero, complemento) 
        //chama o construtor da classe base Pessoa para inicializar os atributos herdados
        {
            //atribui os valores dos parametros aos atributos da classe Professor
            Titulacao = titulacao;
            AreaAtuacao = areaAtuacao;
        }
}