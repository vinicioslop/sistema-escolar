using System;

namespace sistema_escolar.console
{
    public class MetodosEnum
    {
        public void ExibeDisciplinas()
        {
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                   DISCIPLINAS                    |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("  {0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public void exibeAnos()
        {
            
            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                      ANOS                      |");
            Console.WriteLine("  +================================================+\n");

            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("  {0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }

            Console.Write("\n");
        }
    }
}