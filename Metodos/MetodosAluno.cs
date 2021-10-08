using System;
using sistema_escolar.Repositorios;

namespace sistema_escolar.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        static NotaRepositorio repositorioNotas = new NotaRepositorio();
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

            Console.WriteLine($"NOME......: {aluno.retornaNome()} {aluno.retornaNome()}");
            Console.WriteLine($"CPF.......: {aluno.retornaCPF()}");
            Console.WriteLine($"ANO.......: {aluno.retornaAno()}");
            Console.WriteLine($"STATUS....: {aluno.retornaStatus()}");
            Console.WriteLine($"DESATIVADO: {aluno.retornaDesativado()}");
        }
        public void ListarAlunos()
        {
            var lista = repositorioAlunos.Lista();

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

                Console.WriteLine($"NOME...: {aluno.retornaNome()}");
                Console.WriteLine($"1° NOTA: {n.retornaPrimeiraNota()} | ");
                Console.WriteLine($"2° NOTA: {n.retornaSegundaNota()} | ");
                Console.WriteLine($"3° NOTA: {n.retornaTerceiraNota()} | ");
                Console.WriteLine($"4° NOTA: {n.retornaQuartaNota()} | ");
                Console.WriteLine($"MÉDIA..: {n.retornaMedia()} | ");
            }
        }
        public void InserirNota()
        {
            Console.Write("Informe o ID do aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Nota nota = criaNota(idE);

            repositorioNotas.Inserir(nota);
        }
        public Nota criaNota(int id)
        {
            Console.WriteLine("\nInforme a disciplina: ");

            MetodosProfessor metodosProfessor = new MetodosProfessor();

            metodosProfessor.ExibeDisciplinas();

            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscolha a nota a ser inserida a partir das opções abaixo");

            Console.WriteLine("1 - Primeira Nota");
            Console.WriteLine("2 - Segunda Nota");
            Console.WriteLine("3 - Terceira Nota");
            Console.WriteLine("4 - Quarta Nota");

            int opcaoNota = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInsira a nota do aluno: ");
            double notaE = Convert.ToDouble(Console.ReadLine());

            Nota nota = new Nota(id, (Disciplina)disciplina);

            nota.InserirNota(opcaoNota, notaE);

            Console.Clear();

            Console.WriteLine("Dados digitados:");
            Console.Write("\n");
            Console.WriteLine($"ID........: {id}");
            Console.WriteLine($"DISCIPLINA: {Enum.GetName(typeof(Disciplina), disciplina)}");
            Console.WriteLine($"NOTA......: {notaE}");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            return nota;
        }
        public void DesativarAluno()
        {
            Console.Write("Informe o ID do aluno: ");
            int idE = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idE) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            repositorioAlunos.Desativa(idE);
        }
    }
}