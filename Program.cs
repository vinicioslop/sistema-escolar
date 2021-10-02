using System;
using sistema_escolar.Metodos;

namespace sistema_escolar
{
    class Program
    {
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
                InserirNota();
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
                    CadastrarAluno();
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
        public static void CadastrarProfessor()
        {
            MetodosProfessor repositorio = new MetodosProfessor();

            repositorio.CadastrarProfessor();
        }
        public static void ListarProfessores()
        {
            MetodosProfessor repositorio = new MetodosProfessor();

            repositorio.ListarProfessores();
        }
        public static void ListarProfessor()
        {
            MetodosProfessor repositorio = new MetodosProfessor();

            repositorio.ListarProfessor();
        }
        public static void AtualizarProfessor()
        {
            MetodosProfessor repositorio = new MetodosProfessor();

            repositorio.AtualizarProfessor();
        }
        public static void DesativarProfessor()
        {
            MetodosProfessor repositorio = new MetodosProfessor();

            repositorio.DesativarProfessor();
        }
        public static void CadastrarAluno()
        {
            MetodosAluno repositorio = new MetodosAluno();

            repositorio.CadastrarAluno();
        }
        public static void ListarAlunos()
        {
            MetodosAluno repositorio = new MetodosAluno();

            repositorio.ListarAlunos();
        }
        public static void ListarAluno()
        {
            MetodosAluno repositorio = new MetodosAluno();

            repositorio.ListarAluno();
        }
        public static void AtualizarAluno()
        {
            MetodosAluno repositorio = new MetodosAluno();

            repositorio.AtualizarAluno();
        }
        public static void InserirNota()
        {
            MetodosProfessor metodosProfessor = new MetodosProfessor();

            metodosProfessor.InserirNota();
        }
        public static void DesativarAluno()
        {
            MetodosAluno repositorio = new MetodosAluno();

            repositorio.DesativarAluno();
        }
    }
}
