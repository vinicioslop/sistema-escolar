using System;
using sistema_escolar.Metodos;

namespace sistema_escolar.Views
{
    public class ViewProfessor
    {
        public static MetodosProfessor metodosProfessor = new MetodosProfessor();
        public static MetodosAluno metodosAluno = new MetodosAluno();
        public static ViewAluno viewAluno = new ViewAluno();
        public void HomeProfessor()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Interface de Professor");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - LISTAR ALUNOS");
                Console.WriteLine("2 - LISTAR ALUNO");
                Console.WriteLine("3 - LISTAR NOTAS");
                Console.WriteLine("4 - INSERÇÃO DE NOTA DE ALUNO");
                Console.WriteLine("5 - ALTERAR STATUS DE ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesProfessor(opcao);
            } while (opcao != "X");
        }
        public void OpcoesProfessor(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    listarAlunos();
                    break;
                case "2":
                    listarAluno();
                    break;
                case "3":
                    listarNotas();
                    break;
                case "4":
                    inserirNota();
                    break;
                case "5":
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public static void listarAlunos()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE ALUNOS");

            Console.Write("\n");

            try
            {
                metodosAluno.ListarAlunos();

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public static void listarAluno()
        {
            Console.Clear();

            Console.WriteLine("VIZUALIZAR DE ALUNO");

            Console.Write("\n");

            try
            {
                viewAluno.listarAluno();

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void listarNotas()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE NOTAS");

            Console.Write("\n");

            try
            {
                metodosProfessor.ListarNotas();

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public static void inserirNota()
        {
            Console.Clear();

            Console.WriteLine("INSERÇÃO DE NOTA");

            Console.Write("\n");

            try
            {
                metodosProfessor.InserirNota();

                Console.Write("\n");
                Console.Write("Nota inserida com sucesso.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}