using ClassesHerança;
internal class Program
{

    List<Pessoa> listapessoas = new List<Pessoa>();

    public Program()
    {
        Pessoa pessoa1 = new Pessoa("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua A", "Centro", "Cidade X"), "123", "Apto 101");
        listapessoas.Add(pessoa1);

        Funcionario funcionario1 = new Funcionario("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua A", "Centro", "Cidade X"), "123", "Apto 101", "2023001", 3000);
        listapessoas.Add(funcionario1);

        Aluno aluno1 = new Aluno("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua A", "Centro", "Cidade X"), "123", "Apto 101", "2023001", new Curso { Nome = "Sistemas de Informação" });
        Aluno aluno2 = new Aluno("Maria Silva", "987.654.321-00", "MG-87.654.321", "25 anos", new Logradouro("Rua B", "Bairro Y", "Cidade Z"), "456", "Casa", "2023002", new Curso { Nome = "Engenharia de Software" });
        Aluno aluno3 = new Aluno("João Pereira", "111.222.333-44", "MG-11.222.333", "28 anos", new Logradouro("Rua C", "Bairro W", "Cidade V"), "789", "Apto 202", "2023003", new Curso { Nome = "Ciência da Computação" });
        listapessoas.Add(aluno1);
        listapessoas.Add(aluno2);
        listapessoas.Add(aluno3);

        Professor professor1 = new Professor("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua A", "Centro", "Cidade X"), "123", "Apto 101", "Mestre", "Área de Tecnologia");
        Professor professor2 = new Professor("Luciano Coelho", "555.666.777-88", "MG-55.666.777", "40 anos", new Logradouro("Rua D", "Bairro Z", "Cidade Y"), "321", "Casa", "Doutor", "Área de Programação");
        listapessoas.Add(professor1);
        listapessoas.Add(professor2);

        Coordenador coordenador1 = new Coordenador("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua A", "Centro", "Cidade X"), "123", "Apto 101", "Mestre", 10000, "AbcBolinhas");
        listapessoas.Add(coordenador1);

            

        ListarPessoas(listapessoas);
        
    }
        static void ListarPessoas(List<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, RG: {pessoa.Rg}, Idade: {pessoa.Idade}, Endereço: {pessoa.Endereco}, Número: {pessoa.Numero}, Complemento: {pessoa.Complemento}");
            }
        }
        private static void Main(string[] args)
        {
            _ = new Program();
        }
    
}