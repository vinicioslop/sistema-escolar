using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewAluno
    {
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
                Console.WriteLine("  | 1 - VIZUALIZAR DADOS CADASTRAIS DO ALUNO       |");
                Console.WriteLine("  | 2 - VIZUALIZAR NOTAS DO ALUNO NO SISTEMA       |");
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

        public static void listarNota()
        {
            try
            {
                Metodos.Metodos.ListarNota();
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
