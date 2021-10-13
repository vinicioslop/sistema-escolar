using System;
using sistema_escolar.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        static NotaRepositorio repositorioNotas = new NotaRepositorio();
        MetodosProfessor metodosProfessor = new MetodosProfessor();
        public void CadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO");

            Aluno aluno = criaAluno();

            repositorioAlunos.Inserir(aluno);
        }
        public void ListarAluno()
        {
            Console.Write("Insira o seu ID: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (repositorioAlunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idE);

            Console.WriteLine("DADOS NO SISTEMA");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {aluno.Nome} {aluno.Sobrenome}");
            Console.WriteLine($"CPF.......: {aluno.CPF}");
            Console.WriteLine($"ANO.......: {aluno.Ano}");
            Console.WriteLine($"STATUS....: {aluno.Status}");
        }
        public void ListarAlunos()
        {
            var lista = repositorioAlunos.Lista();

            foreach (var aluno in lista)
            {
                Console.Write($"ID: {aluno.retornaId()} | NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($" | ANO: {aluno.Ano} | STATUS: {aluno.Status}");
            }

            if (lista.Count == 0)
                throw new Exception("Não há alunos cadastrados.");
        }
        public Aluno criaAluno()
        {
            Console.Write("Digite o Nome.........: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome....: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF..........: ");
            string cpfE = Console.ReadLine();

            ExibeAnos();

            Console.Write("Escolha o Ano do Aluno: ");
            int anoE = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("DADOS INSERIDOS\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), anoE)}");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Aluno(
                id: repositorioAlunos.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                ano: (Ano)anoE
            );
        }
        public void ExibeAnos()
        {
            Console.WriteLine("\nANOS\n");

            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }

            Console.Write("\n");
        }
        public void AtualizarAluno()
        {
            Console.Write("Informe o ID do Aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = criaAluno();

            repositorioAlunos.Atualizar(idE, aluno);
        }
        public void ListarNotas()
        {
            var listaNotas = repositorioNotas.Lista();

            if (listaNotas == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            foreach (var n in listaNotas)
            {
                var aluno = repositorioAlunos.RetornaPorId(n.IdAluno);

                Console.WriteLine($"NOME...: {aluno.Nome}");
                Console.Write($"1° NOTA: {n.PriNota} | ");
                Console.Write($"2° NOTA: {n.SegNota} | ");
                Console.Write($"3° NOTA: {n.TerNota} | ");
                Console.Write($"4° NOTA: {n.QuaNota} | ");
                Console.WriteLine($"MÉDIA..: {n.Media}\n");
            }
        }
        public void InserirNota()
        {
            Console.WriteLine("A implementar...");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}