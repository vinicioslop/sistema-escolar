using System;
using sistema_escolar.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosProfessor
    {
        public static ProfessorRepositorio repositorioProfessores = new ProfessorRepositorio();
        public static NotaRepositorio repositorioNotas = new NotaRepositorio();

        public void IniciaProfessoresMockados()
        {
            // DADOS MOCKADOS DE ALUNOS
            repositorioProfessores.Inserir(new Professor(
                repositorioProfessores.ProximoId(),
                "Anderson",
                "Santos",
                "14115515112",
                (Disciplina)1)
            );
            repositorioProfessores.Inserir(new Professor(
                repositorioProfessores.ProximoId(),
                "Victor",
                "Lopes",
                "134141366346",
                (Disciplina)4)
            );
            repositorioProfessores.Inserir(new Professor(
                repositorioProfessores.ProximoId(),
                "José",
                "Ferreira",
                "99999999999",
                (Disciplina)3)
            );
        }
        public void ListarProfessores()
        {
            var lista = repositorioProfessores.Lista();

            foreach (var professor in lista)
            {
                Console.Write($"ID: {professor.Id} | NOME: {professor.Nome} {professor.Sobrenome}");
                Console.WriteLine($" | DISCIPLINA: {professor.Disciplina}");
            }

            if (lista.Count == 0)
                throw new Exception("Não há professores cadastrados.");
        }
        public void ListarProfessor()
        {
            Console.Clear();

            Console.Write("Insira o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Professor professor = repositorioProfessores.RetornaPorId(idE);

            if (professor == null)
                throw new Exception("Não professor cadastrado com este ID.");

            Console.WriteLine("DADOS NO SISTEMA\n");

            Console.WriteLine($"NOME......: {professor.Nome} {professor.Sobrenome}");
            Console.WriteLine($"CPF.......: {professor.CPF}");
            Console.WriteLine($"DISCIPLINA: {professor.Disciplina}");
        }
        public void CadastrarProfessor()
        {
            Console.Clear();

            Professor professor = criaProfessor();

            repositorioProfessores.Inserir(professor);
        }
        public void ExibeDisciplinas()
        {
            Console.WriteLine("\nDISCIPLINAS\n");

            foreach (int i in Enum.GetValues(typeof(Disciplina)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Disciplina), i));
            }

            Console.Write("\n");
        }
        public void AtualizarProfessor()
        {
            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessores.RetornaPorId(idE) == null)
                throw new Exception("Não há professor cadastrado com este ID.");

            Professor professor = criaProfessor();

            repositorioProfessores.Atualizar(idE, professor);
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

            Console.WriteLine("DADOS INSERIDOS\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplinaE)}");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Professor(
                id: repositorioProfessores.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                disciplina: (Disciplina)disciplinaE
            );
        }
    }
}