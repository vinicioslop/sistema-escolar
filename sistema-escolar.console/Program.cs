using System;
using sistema_escolar.console.Metodos;
using sistema_escolar.console.Views;

namespace sistema_escolar.console
{
    class Program
    {
        public static ViewSecretaria viewSecretaria = new ViewSecretaria();
        public static ViewProfessor viewProfessor = new ViewProfessor();
        public static ViewAluno viewAluno = new ViewAluno();

        // APAGAR DEPOIS SE NECESSARIO
        public static MetodosProfessor metodosProfessor = new MetodosProfessor();
        public static MetodosAluno metodosAluno = new MetodosAluno();
        static void Main(string[] args)
        {
            string opcao;
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
                Console.WriteLine("  | 0 - INICIAR DADOS MOCKADOS                     |");
                Console.WriteLine("  +------------------------------------------------+");
                Console.WriteLine("  | X - SAIR                                       |");
                Console.WriteLine("  +================================================+");

                Console.Write("\n  Informe a opção desejada: ");
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
                case "0":
                    metodosAluno.IniciaAlunosMockados();
                    metodosAluno.IniciaNotasMockadas();
                    metodosProfessor.IniciaProfessoresMockados();
                    break;
                case "X":
                    Console.WriteLine("\n  Saindo...");
                    break;
                default:
                    Console.WriteLine("\n  Opção digitada é inválida! Tente novamente.");
                    EsperaTecla();
                    break;
            }
        }
        static void EsperaTecla()
        {
            Console.Write("\n  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
