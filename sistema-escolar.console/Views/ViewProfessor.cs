using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewProfessor
    {
        public static MetodosProfessor metodosProfessor = new MetodosProfessor();
        public static MetodosAluno metodosAluno = new MetodosAluno();
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
                Console.WriteLine("  | 1 - LISTAR ALUNOS                              |");
                Console.WriteLine("  | 2 - LISTAR ALUNO                               |");
                Console.WriteLine("  | 3 - LISTAR NOTAS                               |");
                Console.WriteLine("  | 4 - INSERÇÃO DE NOTA DO ALUNO                  |");
                Console.WriteLine("  | 5 - CALCULAR MÉDIA DO ALUNO                    |");
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
                metodosAluno.ListarAlunos();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        public static void listarAluno()
        {
            try
            {
                ViewAluno.listarAluno();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        public static void listarNotas()
        {
            try
            {
                metodosAluno.ListarNotas();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        public static void inserirNota()
        {
            try
            {
                metodosAluno.InserirNota();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        public static void calcularMedia()
        {
            try
            {
                metodosAluno.CalcularMedia();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        public static void TrataErro(Exception ex)
        {
            Console.WriteLine("  Ocorreu um erro ao realizar esta operação.");
            Console.WriteLine($"  Contexto: {ex.Message}");
        }
        public static void EsperaTecla()
        {
            Console.Write("  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}