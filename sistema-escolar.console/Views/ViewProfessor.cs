using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
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

                Console.WriteLine("INTERFACE DO PROFESSOR\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - LISTAR ALUNOS");
                Console.WriteLine("2 - LISTAR ALUNO");
                Console.WriteLine("3 - LISTAR NOTAS");
                Console.WriteLine("4 - INSERÇÃO DE NOTA DO ALUNO");
                Console.WriteLine("5 - CALCULAR MÉDIA DO ALUNO");
                Console.WriteLine("6 - ALTERAR STATUS DO ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME\n");

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
                    calcularMedia();
                    break;
                case "6":
                    alterarStatusAluno();
                    break;
                default:
                    break;
            }
        }
        public void listarAlunos()
        {
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
            try
            {
                metodosAluno.InserirNota();

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
        public void calcularMedia()
        {
            try
            {
                metodosAluno.CalculaMedia();

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
        public void alterarStatusAluno()
        {
            try
            {
                metodosAluno.AlteraStatus();

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
    }
}