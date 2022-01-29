using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewAluno
    {
        public void HomeAluno()
        {
            string entrada;
            bool nulo = false;

            do
            {
                Console.Clear();

                exibeOpcoes();

                do
                {
                    Console.Write("\n  Informe a opção desejada: ");
                    entrada = Console.ReadLine().ToUpper();

                    if (MetodosComplementares.VerificaSeNuloS(entrada))
                    {
                        nulo = true;

                        Console.WriteLine("\n  Entrada informada esta vazia.");
                    }

                } while (nulo);

                opcoes(entrada);
            } while (entrada != "X");
        }
        public void exibeOpcoes()
        {
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
        }
        public void opcoes(string entrada)
        {
            switch (entrada)
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

        public void listarNota()
        {
            try
            {
                Metodos.Metodos.ListarNota(-1);
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
