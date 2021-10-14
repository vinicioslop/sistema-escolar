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

                Console.WriteLine("INTERFACE DO ALUNO\n");

                Console.WriteLine("Insira a opção com base na ação preferida:");
                Console.WriteLine("1 - VIZUALIZAR DADOS DO ALUNO");
                Console.WriteLine("2 - VIZUALIZAR NOTAS DO ALUNO");
                Console.WriteLine("X - VOLTAR PARA A HOME\n");

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

            Console.WriteLine("LISTAGEM DE ALUNO\n");

            try
            {
                metodosAluno.ListarAluno();

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void listarNota()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE NOTA\n");

            try
            {
                Console.WriteLine("A implementar...");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar esta operação.\n");
                Console.WriteLine($"Contexto: {ex.Message}");

                Console.Write("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}