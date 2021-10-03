using System;
using sistema_escolar.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosProfessor
    {
        public static ProfessorRepositorio repositorioProfessor = new ProfessorRepositorio();
        public static AlunoRepositorio repositorioAluno = new AlunoRepositorio();
        public static NotaRepositorio repositorioNota = new NotaRepositorio();

        public void ListarProfessores()
        {
            var lista = repositorioProfessor.Lista();

            foreach (var professor in lista)
            {
                Console.Write($"ID: {professor.Id} | NOME: {professor.retornaNome()} {professor.retornaSobrenome()}");
                Console.WriteLine($" | DISCIPLINA: {professor.retornaDisciplina()} | DESATIVADO: {professor.retornaDesativado()}");
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

            Professor professor = repositorioProfessor.RetornaPorId(idE);

            if (professor == null)
                throw new Exception("Não professor cadastrado com este ID.");

            Console.WriteLine("DADOS NO SISTEMA");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {professor.retornaNome()} {professor.retornaNome()}");
            Console.WriteLine($"CPF.......: {professor.retornaCPF()}");
            Console.WriteLine($"DISCIPLINA: {professor.retornaDisciplina()}");
            Console.WriteLine($"DESATIVADO: {professor.retornaDesativado()}");
        }
        public void CadastrarProfessor()
        {
            Console.Clear();

            Professor professor = criaProfessor();

            repositorioProfessor.Inserir(professor);
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
            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessor.RetornaPorId(idE) == null)
                throw new Exception("Não há professor cadastrado com este ID.");

            Professor professor = criaProfessor();

            repositorioProfessor.Atualizar(idE, professor);
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
                id: repositorioProfessor.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                disciplina: (Disciplina)disciplinaE
            );
        }
        public void ListarNotas()
        {
            var listaNotas = repositorioNota.Lista();

            if(listaNotas == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            foreach (var n in listaNotas)
            {
                Console.Write($"NOME...: {repositorioAluno.RetornaPorId(n.IdAluno)}");
                Console.Write($"1° NOTA: {n.retornaPrimeiraNota()} | ");
                Console.Write($"2° NOTA: {n.retornaSegundaNota()} | ");
                Console.Write($"3° NOTA: {n.retornaTerceiraNota()} | ");
                Console.Write($"4° NOTA: {n.retornaQuartaNota()} | ");
                Console.WriteLine($"MÉDIA..: {n.retornaMedia()} | ");

            }
        }
        public void InserirNota()
        {
            Console.Write("Informe o ID do aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioAluno.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Nota nota = criaNota(idE);

            repositorioNota.Inserir(nota);
        }
        public Nota criaNota(int id)
        {
            Console.Write("\n");

            Console.Write("Informe a disciplina: ");
            Console.Write("\n");

            ExibeDisciplinas();

            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Escolha a nota a ser inserida a partir das opções abaixo");
            Console.Write("\n");

            Console.WriteLine("1 - Primeira Nota");
            Console.WriteLine("2 - Segunda Nota");
            Console.WriteLine("3 - Terceira Nota");
            Console.WriteLine("4 - Quarta Nota");

            int opcaoNota = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Insira a nota do aluno: ");
            double notaE = Convert.ToDouble(Console.ReadLine());

            Nota nota = new Nota(id, (Disciplina)disciplina);

            nota.InserirNota(opcaoNota, notaE);

            Console.Clear();

            Console.WriteLine("Dados digitados:");
            Console.Write("\n");
            Console.WriteLine($"ID........: {id}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplina)}");
            Console.WriteLine($"NOTA......: {notaE}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return nota;
        }
        public void DesativarProfessor()
        {
            Console.Write("Informe o ID do professor: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessor.RetornaPorId(idE) == null)
                throw new Exception("Não há professor cadastrado com este ID.");

            repositorioProfessor.Desativa(idE);
        }
    }
}