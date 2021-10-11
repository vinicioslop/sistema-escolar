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

                Console.WriteLine($"NOME...: {aluno.Nome}");
                Console.Write($"1° NOTA: {n.PrimeiraNota} | ");
                Console.Write($"2° NOTA: {n.SegundaNota} | ");
                Console.Write($"3° NOTA: {n.TerceiraNota} | ");
                Console.Write($"4° NOTA: {n.QuartaNota} | ");
                Console.WriteLine($"MÉDIA..: {n.Media}\n");
            }
        }
        public void InserirNota()
        {
            var lista = repositorioNotas.Lista();

            Console.Write("Informe o ID do aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            metodosProfessor.ExibeDisciplinas();

            Console.Write("\nInforme a disciplina: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            foreach (var nota in lista)
            {
                if (nota.IdAluno == idAluno && nota.retornaDisciplina() == (Disciplina)disciplina)
                {
                    var notaE = atualizaNota(idAluno, disciplina);
                    repositorioNotas.Atualizar(notaE.IdNota, notaE);
                }
                else
                {
                    var notaE = novaNota(idAluno, disciplina);
                    repositorioNotas.Inserir(notaE);
                }
            }
        }
        public Nota novaNota(int idAluno, int disciplina)
        {
            Console.Write("Informe a nota do aluno: ");
            double notaEntrada = Convert.ToDouble(Console.ReadLine());

            Nota nota = new Nota(repositorioNotas.ProximoId(), idAluno, (Disciplina)disciplina);

            nota.PrimeiraNota = notaEntrada;

            return nota;
        }
        public Nota atualizaNota(int idAluno, int disciplina)
        {
            var lista = repositorioNotas.Lista();
            int idNota = -1;

            Console.WriteLine("Escolha com base nas opções\n");

            Console.WriteLine("1 - Primeira Nota");
            Console.WriteLine("2 - Segunda Nota");
            Console.WriteLine("3 - Terceira Nota");
            Console.WriteLine("4 - Quarta Nota");

            Console.Write("Informe a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a nota do aluno: ");
            double notaEntrada = Convert.ToDouble(Console.ReadLine());

            foreach (var n in lista)
            {
                if (n.IdAluno == idAluno && (n.retornaDisciplina() == (Disciplina)disciplina))
                {
                    idNota = n.IdNota;
                }
            }

            if (idNota != -1)
            {
                Nota nota = repositorioNotas.RetornaPorId(idNota);

                switch (opcao)
                {
                    case 1:
                        nota.PrimeiraNota = notaEntrada;
                        break;
                    case 2:
                        nota.SegundaNota = notaEntrada;
                        break;
                    case 3:
                        nota.TerceiraNota = notaEntrada;
                        break;
                    case 4:
                        nota.QuartaNota = notaEntrada;
                        break;
                }
                return nota;
            }
            else
            {
                throw new Exception("Não há nota existente neste aluno com esta disciplina.");
            }
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