namespace ClassesHerança;

public class TecnicoAdministrativo : Funcionario
{
    public string Funcao {get; set;}
    

    //construtor com parametros OPCIONAIS para facilitar a criação de objetos TecnicoAdministrativo
    //os parametros do construtor de TecnicoAdministrativo incluem os parametros da classe base Funcionario e os atributos da classe TecnicoAdministrativo
    public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string funcao = "")
        : base(nome, cpf, rg, idade, endereco, numero, complemento, matricula, salario)
        {
            //atribui os valores dos parametros aos atributos da classe TecnicoAdministrativo
            Funcao = funcao;
        }
}