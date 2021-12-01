using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewSecretaria
    {
        public void HomeSecretaria()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("  +================================================+");
                Console.WriteLine("  |           Interface de Secretario(a)           |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | Insira a opção com base na ação preferida:     |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | 1 - LISTAR ALUNOS                              |");
                Console.WriteLine("  | 2 - LISTAR PROFESSORES                         |");
                Console.WriteLine("  | 3 - CADASTRAR ALUNO                            |");
                Console.WriteLine("  | 4 - CADASTRAR PROFESSOR                        |");
                Console.WriteLine("  | 5 - ATUALIZAR ALUNO                            |");
                Console.WriteLine("  | 6 - ATUALIZAR PROFESSOR                        |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | X - VOLTAR PARA A HOME                         |");
                Console.WriteLine("  +================================================+");

                Console.Write("\n  Informe a opção desejada: ");
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
                default:
                    break;
            }
        }
        public void cadastrarProfessor()
        {
            try
            {
                Metodos.Metodos.CadastrarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void atualizarProfessor()
        {
            try
            {
                Metodos.Metodos.AtualizarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarProfessores()
        {
            try
            {
                Metodos.Metodos.ListarProfessores();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void cadastrarAluno()
        {
            try
            {
                Metodos.Metodos.CadastrarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void atualizarAluno()
        {
            try
            {
                Metodos.Metodos.AtualizarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarAlunos()
        {
            try
            {
                Metodos.Metodos.ListarAlunos();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErro(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
    }
}