using System;
using sistema_escolar.Metodos;

namespace sistema_escolar.Views
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

                Console.WriteLine("Interface de Aluno");

                Console.Write("\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - VIZUALIZAR DADOS DE ALUNO");
                Console.WriteLine("2 - VIZUALIZAR NOTAS DE ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME");

                Console.Write("\n");

                Console.Write("Informe a opção desejada: ");
                opcao = Console.ReadLine().ToUpper();

                OpcoesAluno(opcao);
            } while (opcao != "X");
        }
        public void OpcoesAluno(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    listarAluno();
                    break;
                case "2":
                    break;
                case "x":
                    break;
                default:
                    break;
            }
        }
        public void listarAluno()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE ALUNO");

            Console.Write("\n");

            try
            {
                metodosAluno.ListarAluno();

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.");
                Console.Write("\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\n");
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}