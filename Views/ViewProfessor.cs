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

                Console.WriteLine("Interface de Professor\n");

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
        public void listarAlunos()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE ALUNOS\n");

            try
            {
                metodosAluno.ListarAlunos();

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void listarAluno()
        {
            Console.Clear();

            Console.WriteLine("VIZUALIZAR DE ALUNO\n");

            try
            {
                viewAluno.listarAluno();

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void listarNotas()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE NOTAS\n");

            try
            {
                metodosAluno.ListarNotas();

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void inserirNota()
        {
            Console.Clear();

            Console.WriteLine("INSERÇÃO DE NOTA\n");

            try
            {
                metodosAluno.InserirNota();

                Console.WriteLine("\nNota inserida com sucesso.");
                
                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}