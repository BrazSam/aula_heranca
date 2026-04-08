namespace ClassesHerança;

public class Aluno : Pessoa
{
    public string Matricula {get; set;}
    public Curso Curso {get; set;} //ASSOCIAÇÃO com a classe Curso

    //construtor com parametros OPCIONAIS para facilitar a criação de objetos Aluno
    //os parametros do construtor de Aluno incluem os parametros da classe base Pessoa e os atributos da classe Aluno
    public Aluno(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "", string matricula = "", Curso curso = null)
        : base(nome, cpf, rg, idade, endereco, numero, complemento)
        {
            //atribui os valores dos parametros aos atributos da classe Aluno
            Matricula = matricula;
            Curso = curso;
        }
}