using System;
using sistema_escolar.Classes.Repositorios;

namespace sistema_escolar
{
    class Program
    {
        static AlunoRepositorio alunos = new AlunoRepositorio();
        static ProfessorRepositorio professores = new ProfessorRepositorio();
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Bem-vindo ao Sistema Escolar Simplficado");
                Console.WriteLine("da Escola Estadual de Algum Lugar!");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base no tipo de acesso preferido:");
                Console.WriteLine("1 - SECRETARIA");
                Console.WriteLine("2 - PROFESSOR");
                Console.WriteLine("3 - ALUNO");
                Console.WriteLine("X - SAIR");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                Opcoes(opcao);
            } while (opcao != "X");
        }
        public static void Opcoes(string opcao)
        {
            Console.Write("\n");

            switch (opcao)
            {
                case "1":
                    ViewSecretaria();
                    break;
                case "2":
                    ViewProfessor();
                    break;
                case "3":
                    ViewAluno();
                    break;
                case "X":
                    break;
                default:
                    Console.WriteLine("Opção digitada é inválida!");
                    break;
            }
        }
        public static void ViewProfessor()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Interface de Professor");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - LISTAGEM DE PROFESSORES");
                Console.WriteLine("2 - INSERÇÃO DE NOTA DE ALUNO");
                Console.WriteLine("3 - VIZUALIZAR ALUNOS");
                Console.WriteLine("4 - VIZUALIZAR ALUNO");
                Console.WriteLine("5 - ALTERAR STATUS DE ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesProfessor(opcao);
            } while (opcao != "X");
        }
        public static void OpcoesProfessor(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    ListarProfessores();
                    break;
                case "2":
                    break;
                case "3":
                ListarAlunos();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public static void ListarProfessores()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE PROFESSORES");

            Console.Write("\n");

            var lista = professores.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há professores cadastrados.");

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                foreach (var professor in lista)
                {
                    Console.Write($"ID: {professor.Id} | NOME: {professor.retornaNome()} {professor.retornaSobrenome()}");
                    Console.WriteLine($" | DISCIPLINA: {professor.retornaDisciplina()} | DESATIVADO: {professor.retornaDesativado()}");
                }

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public static void CadastrarProfessor()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE PROFESSOR");

            Console.Write("\n");

            Professor professor = criaProfessor();

            professores.Inserir(professor);
        }
        public static void ExibeDisciplinas()
        {
            Console.Write("\n");

            Console.WriteLine("DISCIPLINAS");

            Console.Write("\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public static void AtualizarProfessor()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR");

            Console.Write("\n");

            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Professor professor = criaProfessor();

            professores.Atualizar(idE, professor);

            Console.Write("\n");

            Console.WriteLine("Professor atualizado com sucesso!");

            Console.Clear();

            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static Professor criaProfessor()
        {
            Console.Write("Digite o Nome.......: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome..: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF........: ");
            string cpfE = Console.ReadLine();

            ExibeDisciplinas();

            Console.Write("Escolha a Disciplina: ");
            int disciplinaE = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("DADOS INSERIDOS");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplinaE)}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Professor(
                id: professores.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                disciplina: (Disciplina)disciplinaE
            );
        }
        public static void DesativarProfessor()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR PROFESSOR");

            Console.Write("\n");

            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            professores.Desativa(idE);

            Console.Write("\n");

            Console.WriteLine("Professor desativado com sucesso!");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static void ViewSecretaria()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Interface de Secretario(a)");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - VIZUALIZAR ALUNOS");
                Console.WriteLine("2 - VIZUALIZAR PROFESSORES");
                Console.WriteLine("3 - CADASTRAR ALUNO");
                Console.WriteLine("4 - CADASTRAR PROFESSOR");
                Console.WriteLine("5 - ATUALIZAR ALUNO");
                Console.WriteLine("6 - ATUALIZAR PROFESSOR");
                Console.WriteLine("7 - DESATIVAR ALUNO");
                Console.WriteLine("8 - DESATIVAR PROFESSOR");
                Console.WriteLine("X - VOLTAR PARA A HOME");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesSecretaria(opcao);
            } while (opcao != "X");
        }
        public static void OpcoesSecretaria(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    ListarAlunos();
                    break;
                case "2":
                    ListarProfessores();
                    break;
                case "3":
                    InserirAluno();
                    break;
                case "4":
                    CadastrarProfessor();
                    break;
                case "5":
                    AtualizarAluno();
                    break;
                case "6":
                    AtualizarProfessor();
                    break;
                case "7":
                    DesativarAluno();
                    break;
                case "8":
                    DesativarProfessor();
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public static void ListarAlunos()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE Alunos");

            Console.Write("\n");

            var lista = alunos.Lista();

            if (lista.Count == 0)
            {
                Console.Write("\n");

                Console.WriteLine("Não há alunos cadastrados.");

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                foreach (var aluno in lista)
                {
                    Console.Write($"ID: {aluno.retornaId()} | NOME: {aluno.retornaNome()} {aluno.retornaSobrenome()}");
                    Console.Write($" | ANO: {aluno.retornaAno()} | STATUS: {aluno.retornaStatus()}");
                    Console.WriteLine($" | DESATIVADO: {aluno.retornaDesativado()}");
                }

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public static void ViewAluno()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Interface de Aluno");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - VIZUALIZAR DADOS DE ALUNO");
                Console.WriteLine("2 - VIZUALIZAR NOTAS DE ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesAluno(opcao);
            } while (opcao != "X");
        }
        public static void OpcoesAluno(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    ListarAluno();
                    break;
                case "2":
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public static void ListarAluno()
        {
            Console.Clear();

            Console.Write("Insira o seu ID: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Aluno aluno = alunos.RetornaPorId(idE);

            Console.Clear();

            Console.WriteLine("DADOS NO SISTEMA");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {aluno.retornaNome()} {aluno.retornaNome()}");
            Console.WriteLine($"CPF.......: {aluno.retornaCPF()}");
            Console.WriteLine($"ANO.......: {aluno.retornaAno()}");
            Console.WriteLine($"STATUS....: {aluno.retornaStatus()}");
            Console.WriteLine($"DESATIVADO: {aluno.retornaDesativado()}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static void InserirAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO");

            Console.Write("\n");

            Aluno aluno = criaAluno();

            alunos.Inserir(aluno);
        }
        public static Aluno criaAluno()
        {
            Console.Write("Digite o Nome.........: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome....: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF..........: ");
            string cpfE = Console.ReadLine();

            ExibeAnos();

            Console.Write("Escolha o Ano do Aluno: ");
            int anoE = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("DADOS INSERIDOS");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), anoE)}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Aluno(
                id: alunos.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                ano: (Ano)anoE
            );
        }
        public static void ExibeAnos()
        {
            Console.Write("\n");

            Console.WriteLine("ANOS");

            Console.Write("\n");

            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }

            Console.Write("\n");
        }
        public static void AtualizarAluno()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE ALUNO");

            Console.Write("\n");

            Console.Write("Informe o ID do Aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Aluno aluno = criaAluno();

            alunos.Atualizar(idE, aluno);

            Console.Write("\n");

            Console.WriteLine("Aluno atualizado com sucesso.");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static void DesativarAluno()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR ALUNO");

            Console.Write("\n");

            Console.Write("Informe o ID do aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            alunos.Desativa(idE);

            Console.Write("\n");

            Console.WriteLine("Aluno desativado com sucesso!");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
