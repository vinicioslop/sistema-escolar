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
                Console.WriteLine("1 - PROFESSOR");
                Console.WriteLine("2 - ALUNO");
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
                    ViewProfessor();
                    break;
                case "2":
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
                Console.WriteLine("1 - CADASTRO DE PROFESSOR");
                Console.WriteLine("2 - LISTAGEM DE PROFESSORES");
                Console.WriteLine("3 - INSERÇÃO DE NOTA DE ALUNO");
                Console.WriteLine("4 - VIZUALIZAR ALUNOS");
                Console.WriteLine("5 - VIZUALIZAR ALUNO");
                Console.WriteLine("6 - ALTERAR STATUS DE ALUNO");
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
                    InserirProfessor();
                    break;
                case "2":
                    ListarProfessores();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
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

            var lista = professores.Lista();

            foreach(var professor in lista)
            {
                Console.WriteLine($"ID: {professor.Id} - NOME: {professor.retornaNome()} {professor.retornaSobrenome()} - DISCIPLINA: {professor.retornaDisciplina()}");
            }

            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public static void InserirProfessor()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE PROFESSOR");

            Console.Write("\n");

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

            Professor professor = new Professor(
                id: professores.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                disciplina: (Disciplina)disciplinaE
            );

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
        public static void ViewAluno()
        {
            Console.Clear();
        }
    }
}
