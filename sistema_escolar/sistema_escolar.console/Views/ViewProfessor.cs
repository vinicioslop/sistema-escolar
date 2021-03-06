using sistema_escolar.console.Metodos;

namespace sistema_escolar.console.Views
{
    public class ViewProfessor
    {
        public void HomeProfessor()
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
        }
        public void opcoes(string entrada)
        {
            switch (entrada)
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
