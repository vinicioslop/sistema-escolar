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

                Console.WriteLine("Bem-vindo ao Sistema Escolar Simplficado");
                Console.WriteLine("da Escola Estadual de Algum Lugar!\n");

                Console.WriteLine("Insira a opção com base no tipo de acesso preferido:");
                Console.WriteLine("1 - SECRETARIA");
                Console.WriteLine("2 - PROFESSOR");
                Console.WriteLine("3 - ALUNO");
                Console.WriteLine("0 - INICIAR DADOS MOCKADOS");
                Console.WriteLine("X - SAIR\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                Console.Write("\n");

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
                    metodosProfessor.IniciaProfessoresMockados();
                    break;
                case "X":
                    break;
                default:
                    Console.WriteLine("Opção digitada é inválida!");
                    break;
            }
        }
    }
}
