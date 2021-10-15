using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewSecretaria
    {
        public static MetodosProfessor metodosProfessor = new MetodosProfessor();
        public static MetodosAluno metodosAluno = new MetodosAluno();

        public void HomeSecretaria()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Interface de Secretario(a)\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - LISTAR ALUNOS");
                Console.WriteLine("2 - LISTAR PROFESSORES");
                Console.WriteLine("3 - CADASTRAR ALUNO");
                Console.WriteLine("4 - CADASTRAR PROFESSOR");
                Console.WriteLine("5 - ATUALIZAR ALUNO");
                Console.WriteLine("6 - ATUALIZAR PROFESSOR");
                Console.WriteLine("X - VOLTAR PARA A HOME\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesSecretaria(opcao);
            } while (opcao != "X");
        }
        public void OpcoesSecretaria(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    listarAlunos();
                    break;
                case "2":
                    listarProfessores();
                    break;
                case "3":
                    cadastrarAluno();
                    break;
                case "4":
                    cadastrarProfessor();
                    break;
                case "5":
                    atualizarAluno();
                    break;
                case "6":
                    atualizarProfessor();
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public void cadastrarProfessor()
        {
            try
            {
                metodosProfessor.CadastrarProfessor();

                Console.Clear();

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
        public void atualizarProfessor()
        {
            try
            {
                metodosProfessor.AtualizarProfessor();

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
        public void listarProfessores()
        {
            try
            {
                metodosProfessor.ListarProfessores();

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
        public void cadastrarAluno()
        {
            try
            {
                metodosAluno.CadastrarAluno();

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
        public void atualizarAluno()
        {
            try
            {
                metodosAluno.AtualizarAluno();

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
    }
}