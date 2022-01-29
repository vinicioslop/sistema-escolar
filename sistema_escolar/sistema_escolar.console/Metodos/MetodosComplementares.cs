using sistema_escolar.console.Enum;

namespace sistema_escolar.console.Metodos
{
    public static class MetodosComplementares
    {
        public static void ExibeDisciplinas()
        {
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |       DISCIPLINAS CADASTRADAS NO SISTEMA       |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in System.Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("  {0} - {1}", i, System.Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public static void exibeAnos()
        {
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |          ANOS CADASTRADAS NO SISTEMA           |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in System.Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("  {0} - {1}", i, System.Enum.GetName(typeof(Ano), i));
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
        public static bool VerificaSeNuloS(string entrada)
        {            
            if (String.IsNullOrEmpty(entrada))
                return true;

            return false;
        }
    }
}
