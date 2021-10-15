using System;
using sistema_escolar.console.Repositorios;

namespace sistema_escolar.console.Metodos
{
    public class MetodosProfessor
    {
        public static ProfessorRepositorio repositorioProfessores = new ProfessorRepositorio();
        MetodosEnum metodosEnum = new MetodosEnum();
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
            Console.Clear();
            Console.WriteLine("LISTAGEM DE PROFESSORES\n");

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
            Console.WriteLine("LISTAGEM DE PROFESSOR\n");

            Console.Write("Insira o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Professor professor = repositorioProfessores.RetornaPorId(idE);

            if (professor == null)
                throw new Exception("Não professor cadastrado com este ID.");

            Console.WriteLine("\nDADOS NO SISTEMA\n");

            Console.WriteLine($"NOME......: {professor.Nome} {professor.Sobrenome}");
            Console.WriteLine($"CPF.......: {professor.CPF}");
            Console.WriteLine($"DISCIPLINA: {professor.Disciplina}");
        }
        public void CadastrarProfessor()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE PROFESSOR\n");

            Professor professor = criaProfessor();

            repositorioProfessores.Inserir(professor);
        }
        
        public void AtualizarProfessor()
        {
            Console.Clear();
            Console.WriteLine("ATUALIZAÇÃO DE PROFESSOR\n");
            
            Console.Write("Informe o ID do professor: ");
            int idProfessor = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessores.RetornaPorId(idProfessor) == null)
                throw new Exception("Não há professor cadastrado com este ID.");

            var professorSistema = repositorioProfessores.RetornaPorId(idProfessor);

            Console.WriteLine("\nDADOS INSERIDOS\n");

            Console.WriteLine($"NOME......: {professorSistema.Nome}");
            Console.WriteLine($"SOBRENOME.: {professorSistema.Sobrenome}");
            Console.WriteLine($"CPF.......: {professorSistema.CPF}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), professorSistema.Disciplina)}");

            Professor professor = criaProfessor();

            repositorioProfessores.Atualizar(idProfessor, professor);
        }
        public Professor criaProfessor()
        {
            Console.Write("\n");
            
            Console.Write("Digite o Nome.......: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome..: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF........: ");
            string cpfE = Console.ReadLine();

            metodosEnum.ExibeDisciplinas();

            Console.Write("Escolha a Disciplina: ");
            int disciplinaE = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DADOS INSERIDOS\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplinaE)}\n");

            Console.Write("Pressione qualquer tecla para continuar...");
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