using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewProfessor
    {
        public void HomeProfessor()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("  +================================================+");
                Console.WriteLine("  |             INTERFACE DO PROFESSOR             |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | Insira a opção com base na ação preferida:     |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | 1 - LISTAR ALUNOS CADASTRADOS NO SISTEMA       |");
                Console.WriteLine("  | 2 - LISTAR DADOS DE ALUNO CADASTRADO NO        |");
                Console.WriteLine("  |     SISTEMA                                    |");
                Console.WriteLine("  | 3 - LISTAR NOTAS CADASTRADOS NO SISTEMA        |");
                Console.WriteLine("  | 4 - INSERIR NOTA DE ALUNO                      |");
                Console.WriteLine("  | 5 - CALCULAR MÉDIA DE ALUNO                    |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | X - VOLTAR PARA A HOME                         |");
                Console.WriteLine("  +================================================+");

                Console.Write("\n  Informe a opção desejada: ");
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
                default:
                    break;
            }
        }
        public static void listarAlunos()
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
        public static void listarAluno()
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
        public static void listarNotas()
        {
            try
            {
                Metodos.Metodos.ListarNotas();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public static void inserirNota()
        {
            try
            {
                Metodos.Metodos.InserirNota();
            }
            catch (Exception ex)
            {
                MetodosComplementares.TrataErroGenerico(ex);
                MetodosComplementares.EsperaTecla();
                return;
            }

            MetodosComplementares.EsperaTecla();
        }
        public static void calcularMedia()
        {
            try
            {
                Metodos.Metodos.CalcularMedia();
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