# 🎓 Aula de Herança - POO em C#

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Concluído-green?style=for-the-badge)

> 📚 **Aula 8 - Introdução ao conceito de Herança em Programação Orientada a Objetos**

## 📖 Sobre o Projeto

Este projeto é uma demonstração prática dos conceitos de **Herança** em C#, abordando como criar hierarquias de classes, reutilização de código e especialização de comportamentos.

**Disciplina:** Desenvolvimento de Sistemas
**Instituição:** UNIPLAC - Fase 3

---

## 🏗️ Arquitetura de Classes

### Diagrama de Hierarquia

```
                    ┌─────────────┐
                    │   Pessoa    │  ◄── Classe Base
                    └──────┬──────┘
                           │
           ┌───────────────┼───────────────┐
           │               │               │
    ┌──────▼──────┐ ┌──────▼──────┐   ┌────▼────┐
    │    Aluno    │ │  Funcionario│   │  ...    │
    └─────────────┘ └──────┬──────┘   └─────────┘
                           │
           ┌───────────────┼───────────────┐
           │               │               │
    ┌──────▼──────┐ ┌──────▼──────┐ ┌──────▼──────────┐
    │  Professor  │ │ Coordenador │ │TecnicoAdminist. │
    └─────────────┘ └─────────────┘ └─────────────────┘
```

---

## 📂 Estrutura do Projeto

```
aula_heranca/
│
├── 📁 ClassesHerança/           # Biblioteca de Classes
│   ├── 📄 Pessoa.cs              # Classe base
│   ├── 📄 Aluno.cs               # Herda de Pessoa
│   ├── 📄 Funcionario.cs          # Herda de Pessoa
│   ├── 📄 Professor.cs            # Herda de Funcionario
│   ├── 📄 Coordenador.cs          # Herda de Funcionario
│   ├── 📄 TecnicoAdministrativo.cs# Herda de Funcionario
│   ├── 📄 Logradouro.cs           # Classe de endereço
│   └── 📄 Curso.cs                # Classe de curso
│
├── 📁 AplicaçãoHerança/         # Aplicação Console
│   └── 📄 Program.cs             # Programa principal
│
└── 📄 Herança.slnx              # Arquivo de solução
```

---

## 🧩 Classes

### 👤 Pessoa (Classe Base)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| Nome | string | Nome completo |
| Cpf | string | Cadastro de Pessoa Física |
| Rg | string | Registro Geral |
| Idade | string | Idade |
| Endereco | Logradouro | Objeto de endereço |
| Numero | string | Número do endereço |
| Complemento | string | Complemento |

### 🎓 Aluno (Herda de Pessoa)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| + Matricula | string | Matrícula do aluno |
| + Curso | Curso | Objeto do curso |

### 💼 Funcionario (Herda de Pessoa)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| + Matricula | string | Matrícula do funcionário |
| + Salario | decimal | Salário |

### 👨‍🏫 Professor (Herda de Funcionario)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| + Titulacao | string | Titulação acadêmica |
| + AreaAtuacao | string | Área de atuação |

### 📋 Coordenador (Herda de Funcionario)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| + SenhaAlarme | string | Senha do alarme |

### 🔧 TecnicoAdministrativo (Herda de Funcionario)
| Atributo | Tipo | Descrição |
|----------|------|-----------|
| + Funcao | string | Função exercida |

---

## 🔑 Conceitos Demonstrados

| Conceito | Descrição |
|----------|-----------|
| **Herança Simples** | Classes derivadas herdam atributos e métodos da classe base |
| **Herança em Cascata** | Professor herda de Funcionario que herda de Pessoa |
| **Construtores com Parâmetros Opcionais** | Facilita a criação de objetos |
| **Associação** | Pessoa associa-se com Logradouro; Aluno associa-se com Curso |
| **Polimorfismo** | Lista de Pessoa pode armazenar diferentes tipos derivados |

---

## 🚀 Como Executar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)

### Executando o projeto

```bash
# Clone o repositório
git clone https://github.com/BrazSam/aula_heranca.git

# Entre na pasta do projeto
cd aula_heranca

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run --project AplicaçãoHerança
```

---

## 📝 Exemplo de Uso

```csharp
// Criando um Aluno
Aluno aluno = new Aluno(
    nome: "João Silva",
    cpf: "123.456.789-00",
    rg: "MG-12.345.678",
    idade: "20 anos",
    endereco: new Logradouro("Rua A", "Centro", "Lages"),
    numero: "123",
    complemento: "Apto 101",
    matricula: "2023001",
    curso: new Curso { Nome = "Sistemas de Informação" }
);

// Criando um Professor
Professor professor = new Professor(
    nome: "Carlos Santos",
    titulacao: "Doutor",
    areaAtuacao: "Programação"
);
```

---

## 👨‍💻 Autor

**Samuel Braz dos Santos**

[![GitHub](https://img.shields.io/badge/GitHub-BrazSam-181717?style=for-the-badge&logo=github)](https://github.com/BrazSam)

---

## 📜 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## 🎯 Objetivo Educacional

Este projeto foi desenvolvido como material didático para demonstrar:

1. ✅ Como criar uma classe base
2. ✅ Como derivar classes especializadas
3. ✅ Como utilizar construtores encadeados (`: base()`)
4. ✅ Como aplicar associação entre classes
5. ✅ Como armazenar objetos diferentes em uma lista polimórfica

---

<p align="center">
  <strong>⭐ Se este projeto foi útil, deixe uma estrela! ⭐</strong>
</p>