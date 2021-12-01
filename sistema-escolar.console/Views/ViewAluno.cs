using System;
using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewAluno
    {
        public static MetodosAluno metodosAluno = new MetodosAluno();
        public void HomeAluno()
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("  +================================================+");
                Console.WriteLine("  |               INTERFACE DO ALUNO               |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | Insira a opção com base na ação preferida:     |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | 1 - VIZUALIZAR DADOS DO ALUNO                  |");
                Console.WriteLine("  | 2 - VIZUALIZAR NOTAS DO ALUNO                  |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | X - VOLTAR PARA A HOME                         |");
                Console.WriteLine("  +================================================+");

                Console.Write("\n  Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesAluno(opcao);
            } while (opcao != "X");
        }
        static void OpcoesAluno(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    listarAluno();
                    break;
                case "2":
                    listarNota();
                    break;
                default:
                    break;
            }
        }
        public static void listarAluno()
        {
            try
            {
                metodosAluno.ListarAluno();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }

        public static void listarNota()
        {
            try
            {
                metodosAluno.ListarNota();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                EsperaTecla();
                return;
            }

            EsperaTecla();
        }
        static void TrataErro(Exception ex)
        {
            Console.WriteLine("  Ocorreu um erro ao realizar esta operação.");
            Console.WriteLine($"  Contexto: {ex.Message}");
        }
        static void EsperaTecla()
        {
            Console.Write("  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}