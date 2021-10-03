using System;
using sistema_escolar.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio alunos = new AlunoRepositorio();
        static NotaRepositorio notas = new NotaRepositorio();
        public void CadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("CADASTRO DE ALUNO");

            Console.Write("\n");

            Aluno aluno = criaAluno();

            alunos.Inserir(aluno);
        }
        public void ListarAluno()
        {
            Console.Write("Insira o seu ID: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (alunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = alunos.RetornaPorId(idE);

            Console.WriteLine("DADOS NO SISTEMA");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {aluno.retornaNome()} {aluno.retornaNome()}");
            Console.WriteLine($"CPF.......: {aluno.retornaCPF()}");
            Console.WriteLine($"ANO.......: {aluno.retornaAno()}");
            Console.WriteLine($"STATUS....: {aluno.retornaStatus()}");
            Console.WriteLine($"DESATIVADO: {aluno.retornaDesativado()}");
        }
        public void ListarAlunos()
        {
            var lista = alunos.Lista();

            foreach (var aluno in lista)
            {
                Console.Write($"ID: {aluno.retornaId()} | NOME: {aluno.retornaNome()} {aluno.retornaSobrenome()}");
                Console.Write($" | ANO: {aluno.retornaAno()} | STATUS: {aluno.retornaStatus()}");
                Console.WriteLine($" | DESATIVADO: {aluno.retornaDesativado()}");
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

            Console.WriteLine("DADOS INSERIDOS");

            Console.Write("\n");

            Console.WriteLine($"NOME......: {nomeE}");
            Console.WriteLine($"SOBRENOME.: {sobrenomeE}");
            Console.WriteLine($"CPF.......: {cpfE}");
            Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), anoE)}");

            Console.Write("\n");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return new Aluno(
                id: alunos.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                ano: (Ano)anoE
            );
        }
        public void ExibeAnos()
        {
            Console.Write("\n");

            Console.WriteLine("ANOS");

            Console.Write("\n");

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

            if (alunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = criaAluno();

            alunos.Atualizar(idE, aluno);
        }
        public void DesativarAluno()
        {
            Console.Write("Informe o ID do aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (alunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            alunos.Desativa(idE);
        }
    }
}