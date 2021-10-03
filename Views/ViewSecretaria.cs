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

                Console.WriteLine("Interface de Secretario(a)");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - LISTAR ALUNOS");
                Console.WriteLine("2 - LISTAR PROFESSORES");
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
                    desativarAluno();
                    break;
                case "8":
                    desativarProfessor();
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

            Console.WriteLine("LISTAGEM DE PROFESSORES");

            Console.Write("\n");

            try
            {
                metodosProfessor.ListarProfessores();

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
        public void cadastrarProfessor()
        {
            Console.Clear();

            try
            {
                metodosProfessor.CadastrarProfessor();

                Console.WriteLine("Professor cadastrado com sucesso.");
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
        public void atualizarProfessor()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR");

            Console.Write("\n");

            try
            {
                metodosProfessor.AtualizarProfessor();

                Console.WriteLine("Professor atualizado com sucesso!");
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
        public void desativarProfessor()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR PROFESSOR");

            Console.Write("\n");

            try
            {
                metodosProfessor.DesativarProfessor();

                Console.WriteLine("Professor desativado com sucesso!");

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
        public void listarAlunos()
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
        public void cadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO");

            Console.Write("\n");

            try
            {
                metodosAluno.CadastrarAluno();

                Console.WriteLine("Aluno cadastrado com sucesso!");

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
        public void atualizarAluno()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE ALUNO");

            Console.Write("\n");

            try
            {
                metodosAluno.AtualizarAluno();

                Console.WriteLine("Professor cadastrado com sucesso!");

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
        public void desativarAluno()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAÇÃO DE ALUNO");

            Console.Write("\n");

            try
            {
                metodosAluno.DesativarAluno();

                Console.WriteLine("Aluno desativado com sucesso!");

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
    }
}