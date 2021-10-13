using System;
using sistema_escolar.Metodos;

namespace sistema_escolar.Views
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
                Console.WriteLine("7 - ALTERAR STATUS DO ALUNO");
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
                case "7":
                    alterarStatusAluno();
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public void listarProfessores()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE PROFESSORES\n");

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
        public void cadastrarProfessor()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE PROFESSOR\n");

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
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR\n");

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
        public void cadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO\n");

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
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE ALUNO\n");

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
        public void alterarStatusAluno()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE STATUS DE ALUNO\n");

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