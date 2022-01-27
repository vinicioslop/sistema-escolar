using sistema_escolar.console.Views;

namespace sistema_escolar.console
{
    class Program
    {
        public static ViewSecretaria viewSecretaria = new ViewSecretaria();
        public static ViewProfessor viewProfessor = new ViewProfessor();
        public static ViewAluno viewAluno = new ViewAluno();
        static void Main(string[] args)
        {
            string opcao;

            Metodos.Metodos.IniciaDadosMockados();

            do
            {
                Console.Clear();

                Console.WriteLine("  +================================================+");
                Console.WriteLine("  |    Bem-vindo ao Sistema Escolar Simplficado    |");
                Console.WriteLine("  |       da Escola Estadual de Algum Lugar!       |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | Insira a opção com base no tipo de acesso      |");
                Console.WriteLine("  | preferido:                                     |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | 1 - INTERFACE DE SECRETARIA                    |");
                Console.WriteLine("  | 2 - INTERFACE DE PROFESSOR                     |");
                Console.WriteLine("  | 3 - INTERFACE DE ALUNO                         |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | X - SAIR                                       |");
                Console.WriteLine("  +================================================+");

                Console.WriteLine();

                Console.Write("  Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                Opcoes(opcao);
            } while (opcao != "X");
        }
        public static void Opcoes(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    viewSecretaria.HomeSecretaria();
                    break;
                case "2":
                    viewProfessor.HomeProfessor();
                    break;
                case "3":
                    viewAluno.HomeAluno();
                    break;
                case "X":
                    Console.WriteLine("\n  Saindo...");
                    break;
                default:
                    Console.WriteLine("\n  Opção digitada é inválida! Tente novamente.");
                    Metodos.MetodosComplementares.EsperaTecla();
                    break;
            }
        }
    }
}