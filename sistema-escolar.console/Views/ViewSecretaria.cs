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
                Console.WriteLine("  | 1 - LISTAR DADOS DE ALUNO CADASTRADO NO        |");
                Console.WriteLine("  |     SISTEMA                                    |");
                Console.WriteLine("  | 2 - LISTAR ALUNOS CADASTRADOS NO SISTEMA       |");
                Console.WriteLine("  | 3 - LISTAR DADOS DE PROFESSORES CADASTRADOS NO |");
                Console.WriteLine("  |     SISTEMA                                    |");
                Console.WriteLine("  | 4 - LISTAR PROFESSORES CADASTRADOS NO SISTEMA  |");
                Console.WriteLine("  | 5 - CADASTRAR ALUNO NO SISTEMA                 |");
                Console.WriteLine("  | 6 - CADASTRAR PROFESSOR NO SISTEMA             |");
                Console.WriteLine("  | 7 - ATUALIZAR DADOS DE ALUNO CADASTRADO NO     |");
                Console.WriteLine("  |     SISTEMA                                    |");
                Console.WriteLine("  | 8 - ATUALIZAR DADOS DE PROFESSOR CADASTRADO NO |");
                Console.WriteLine("  |     SISTEMA                                    |");
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
                    listarAluno();
                    break;
                case "2":
                    listarAlunos();
                    break;
                case "3":
                    listarProfessor();
                    break;
                case "4":
                    listarProfessores();
                    break;
                case "5":
                    cadastrarAluno();
                    break;
                case "6":
                    cadastrarProfessor();
                    break;
                case "7":
                    atualizarAluno();
                    break;
                case "8":
                    atualizarProfessor();
                    break;
                default:
                    break;
            }
        }
        public void listarAluno()
        {
            try
            {
                Metodos.Metodos.ListarAluno();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
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
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void listarProfessor()
        {
            try
            {
                Metodos.Metodos.ListarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
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
                MetodosComplementares.TrataErroGenerico(ex);
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
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public void cadastrarProfessor()
        {
            try
            {
                Metodos.Metodos.CadastrarProfessor();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
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
                MetodosComplementares.TrataErroGenerico(ex);
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
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
    }
}