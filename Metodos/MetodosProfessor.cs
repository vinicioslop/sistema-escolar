using System;
using sistema_escolar.Classes.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosProfessor
    {
        public static ProfessorRepositorio repositorio = new ProfessorRepositorio();
        public void ListarProfessores()
        {            
            Console.Clear();

            Console.WriteLine("LISTAGEM DE PROFESSORES");

            Console.Write("\n");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há professores cadastrados.");

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                foreach (var professor in lista)
                {
                    Console.Write($"ID: {professor.Id} | NOME: {professor.retornaNome()} {professor.retornaSobrenome()}");
                    Console.WriteLine($" | DISCIPLINA: {professor.retornaDisciplina()} | DESATIVADO: {professor.retornaDesativado()}");
                }

                Console.Write("\n");

                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        public void ListarProfessor()
        {
            Console.Clear();

            Console.Write("Insira o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Professor professor = repositorio.RetornaPorId(idE);

            Console.Clear();

            Console.WriteLine("DADOS NO SISTEMA");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {professor.retornaNome()} {professor.retornaNome()}");
            Console.WriteLine($"CPF.......: {professor.retornaCPF()}");
            Console.WriteLine($"DISCIPLINA: {professor.retornaDisciplina()}");
            Console.WriteLine($"DESATIVADO: {professor.retornaDesativado()}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void CadastrarProfessor()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE PROFESSOR");

            Console.Write("\n");

            Professor professor = criaProfessor();

            repositorio.Inserir(professor);
        }
        public void ExibeDisciplinas()
        {
            Console.Write("\n");

            Console.WriteLine("DISCIPLINAS");

            Console.Write("\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public void AtualizarProfessor()
        {
            Console.Clear();

            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR");

            Console.Write("\n");

            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Professor professor = criaProfessor();

            repositorio.Atualizar(idE, professor);

            Console.Write("\n");

            Console.WriteLine("Professor atualizado com sucesso!");

            Console.Clear();

            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public Professor criaProfessor()
        {
            Console.Write("Digite o Nome.......: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome..: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF........: ");
            string cpfE = Console.ReadLine();

            ExibeDisciplinas();

            Console.Write("Escolha a Disciplina: ");
            int disciplinaE = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("DADOS INSERIDOS");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplinaE)}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Professor(
                id: repositorio.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                disciplina: (Disciplina)disciplinaE
            );
        }
        public void DesativarProfessor()
        {
            Console.Clear();

            Console.WriteLine("DESATIVAR PROFESSOR");

            Console.Write("\n");

            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            repositorio.Desativa(idE);

            Console.Write("\n");

            Console.WriteLine("Professor desativado com sucesso!");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}