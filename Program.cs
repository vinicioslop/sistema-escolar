using System;
using sistema_escolar.Metodos;
using sistema_escolar.Views;

namespace sistema_escolar
{
    class Program
    {
        public static ViewSecretaria viewSecretaria = new ViewSecretaria();
        public static ViewProfessor viewProfessor = new ViewProfessor();
        public static ViewAluno viewAluno = new ViewAluno();
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Bem-vindo ao Sistema Escolar Simplficado");
                Console.WriteLine("da Escola Estadual de Algum Lugar!");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base no tipo de acesso preferido:");
                Console.WriteLine("1 - SECRETARIA");
                Console.WriteLine("2 - PROFESSOR");
                Console.WriteLine("3 - ALUNO");
                Console.WriteLine("X - SAIR");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                Opcoes(opcao);
            } while (opcao != "X");
        }
        public static void Opcoes(string opcao)
        {
            Console.Write("\n");

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
                    break;
                default:
                    Console.WriteLine("Opção digitada é inválida!");
                    break;
            }
        }
    }
}
