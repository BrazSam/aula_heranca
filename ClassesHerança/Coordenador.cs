namespace ClassesHerança;

public class Coordenador : Funcionario
{
    public string SenhaAlarme {get; set;}
    

    //construtor com parametros OPCIONAIS para facilitar a criação de objetos Coordenador
    //os parametros do construtor de Coordenador incluem os parametros da classe base Funcionario e os atributos da classe Coordenador
    public Coordenador(string nome = "", string cpf = "", string rg = "", string idade = "", Logradouro endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string senhaAlarme = "")
        : base(nome, cpf, rg, idade, endereco, numero, complemento, matricula, salario)
        {
            //atribui os valores dos parametros aos atributos da classe Coordenador
            SenhaAlarme = senhaAlarme;
        }

        public override List<(string campo, string valor)> RetornarDados()
        {
            return new List<(string campo, string valor)>
            {
                ("Nome", Nome),
                ("Cpf", Cpf),
                ("Rg", Rg),
                ("Idade", Idade), 
                
                // Atributos específicos de Funcionário/Coordenador:
                ("Matricula", Matricula),
                ("Salário", Salario.ToString("C")), // Formata o salário como moeda até tentei fazer sem mas parece q é obrigatorio
                ("Senha Alarme", SenhaAlarme)
            };
        }

        public override string ToString()
        {
            return $"{Nome} - {Matricula}";
        }
}