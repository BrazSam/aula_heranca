using ClassesHerança;
internal class Program
{
    //Samuel Braz dos Santos
    List<Pessoa> listapessoas = new List<Pessoa>();

    public Program()
    {
        /*Retirando por conta do abstract na classe:
        Pessoa pessoa1 = new Pessoa("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101");
        listapessoas.Add(pessoa1); */

        /*Retirando por conta do abstract na classe:
        Funcionario funcionario1 = new Funcionario("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101", "2023001", 3000);
        listapessoas.Add(funcionario1);*/

        Aluno aluno1 = new Aluno("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101", "2023001", new Curso { Nome = "Sistemas de Informação" , Codigo = "SI2026"});
        Aluno aluno2 = new Aluno("Maria Silva", "987.654.321-00", "MG-87.654.321", "25 anos", new Logradouro("Rua B", "Bairro Y", "Cidade Z"), "456", "Casa", "2023002", new Curso { Nome = "Engenharia de Software" , Codigo = "ES2026"});
        Aluno aluno3 = new Aluno("João Pereira", "111.222.333-44", "MG-11.222.333", "28 anos", new Logradouro("Rua C", "Bairro W", "Cidade V"), "789", "Apto 202", "2023003", new Curso { Nome = "Ciência da Computação" , Codigo = "CC2026"});
        listapessoas.Add(aluno1);
        listapessoas.Add(aluno2);
        listapessoas.Add(aluno3);

        Professor professor1 = new Professor("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101", "Mestre", "Área de Tecnologia");
        Professor professor2 = new Professor("Luciano Coelho", "555.666.777-88", "MG-55.666.777", "40 anos", new Logradouro("Rua D", "Bairro Z", "Cidade Y"), "321", "Casa", "Doutor", "Área de Programação");
        listapessoas.Add(professor1);
        listapessoas.Add(professor2);

        Coordenador coordenador1 = new Coordenador("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101", "Mestre", 10000, "AbcBolinhas");
        listapessoas.Add(coordenador1);

        
        TecnicoAdministrativo tecnico1 = new TecnicoAdministrativo("Samuel Braz dos Santos", "123.456.789-00", "MG-12.345.678", "30 anos", new Logradouro("Rua AbcBolinhas", "Centro", "Cidade Lages"), "123", "Apto 101", "2023001", 3000, "Suporte Técnico");
        TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo("Ana Oliveira", "222.333.444-55", "MG-22.333.444", "35 anos", new Logradouro("Rua E", "Bairro X", "Cidade W"), "654", "Casa", "2023002", 3500, "Administração");
        listapessoas.Add(tecnico1);
        listapessoas.Add(tecnico2);
            
    
        // Percorre cada pessoa cadastrada na lista
        foreach (var item in listapessoas) 
        {
            // 1. Tipo do objeto (Vai imprimir "Aluno", "Professor", etc.)
            Console.WriteLine($"Tipo do objeto: {item.GetType().Name}"); 

            // 2. A representação em string do objeto (Vai usar o método ToString() de cada classe, mostrando as informações mais relevantes)
            Console.WriteLine($"Representação textual: {item.ToString()}"); 
            
            // 3. O conteúdo do RetornarDados()
            Console.WriteLine("Dados detalhados:");
            // Como RetornarDados devolve uma lista de tuplas, fazemos outro foreach para extrair o campo e o valor
            foreach (var (campo, valor) in item.RetornarDados()) 
            {
                Console.WriteLine($"  - {campo}: {valor}");
            }
            
            // Uma linha em branco apenas para separar uma pessoa da outra na tela
            Console.WriteLine("--------------------------------------------------"); 
        }
    }
        
        /*listar pessoas antigo agora esta sendo usado o de cima, mas deixei aqui caso queira comparar ou usar depois:
        static void ListarPessoas(List<Pessoa> pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Tipo: {pessoa.GetType().Name}"); //usando o get type para mostrar o tipo de pessoa
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"CPF: {pessoa.Cpf}");
                Console.WriteLine($"RG: {pessoa.Rg}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"Endereço: {pessoa.Endereco.Nome}, {pessoa.Endereco.Bairro}, {pessoa.Endereco.Cidade}"); //ajuste para exibir o endereço completo pq tava bugado
                Console.WriteLine($"Número: {pessoa.Numero}");
                Console.WriteLine($"Complemento: {pessoa.Complemento}");
                Console.WriteLine(); // linha em branco separando cada pessoa
            }
        }*/
        private static void Main(string[] args)
        {
            _ = new Program();
        }
    
}