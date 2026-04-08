namespace ClassesHerança;

public class Curso : Object //a classe Curso herda implicitamente da classe Object, que é a classe base de todas as classes em C#.
{
    public string Nome {get; set;}
    public string CargaHoraria {get; set;}
    public string Descricao {get; set;}
    public string Codigo {get; set;}


    //construtor com parametros OPCIONAIS para facilitar a criação de objetos Curso
    public Curso(string nome = "", string cargaHoraria = "", string descricao = "", string codigo = "")
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Descricao = descricao;
            Codigo = codigo;
        }
}