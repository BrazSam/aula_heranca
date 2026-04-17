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

    public override List<(string campo, string valor)> RetornarDados()
        {
            // Cria e retorna uma lista contendo os pares de informações do aluno
            return new List<(string campo, string valor)>
            {
                ("Nome", Nome),
                ("Cpf", Cpf),
                ("Rg", Rg),
                ("Idade", Idade),
                
                // Atributos específicos do Aluno:
                ("Matricula", Matricula),
                ("Curso Nome", Curso.Nome), 
                ("Curso Código", Curso.Codigo) 
            };
        }   

        //polimorfismo: 
    public override string ToString()
        {
            return $"{Nome} - {Matricula}";
        }    
}