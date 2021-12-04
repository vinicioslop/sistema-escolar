using System;

namespace sistema_escolar.console.Metodos
{
    public static class MetodosComplementares
    {
        public static void ExibeDisciplinas()
        {
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |       DISCIPLINAS CADASTRADAS NO SISTEMA       |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("  {0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public static void exibeAnos()
        {
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |          ANOS CADASTRADAS NO SISTEMA           |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("  {0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }

            Console.Write("\n");
        }
        public static void TrataErroGenerico(Exception ex)
        {
            Console.WriteLine("\n  Ocorreu algum problema ao realizar esta operação.");
            Console.WriteLine($"  Mensagem: {ex.Message}");
        }
        public static void EsperaTecla()
        {
            Console.Write("\n  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}