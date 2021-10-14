using System;
using sistema_escolar.console.Repositorios;

namespace sistema_escolar.console.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        static NotaRepositorio repositorioNotas = new NotaRepositorio();
        MetodosProfessor metodosProfessor = new MetodosProfessor();
        public void IniciaAlunosMockados()
        {
            // DADOS MOCKADOS DE ALUNOS
            repositorioAlunos.Inserir(new Aluno(
                repositorioAlunos.ProximoId(),
                "Marcos", "Antonio",
                "12345678901",
                (Ano)1)
            );
            repositorioAlunos.Inserir(new Aluno(
                repositorioAlunos.ProximoId(),
                "José", "Carlos",
                "09876543210",
                (Ano)2)
            );
            repositorioAlunos.Inserir(new Aluno(
                repositorioAlunos.ProximoId(),
                "Ana", "Carla",
                "62548746112",
                (Ano)3)
            );
            repositorioAlunos.Inserir(new Aluno(
                repositorioAlunos.ProximoId(),
                "Julia", "Cristina",
                "26545654612",
                (Ano)4)
            );
            repositorioAlunos.Inserir(new Aluno(
                repositorioAlunos.ProximoId(),
                "Ana", "Beatriz",
                "21473365112",
                (Ano)5)
            );
        }
        public void IniciaNotasMockadas()
        {
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                0,
                (Disciplina)1,
                10
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                1,
                (Disciplina)2,
                9
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                2,
                (Disciplina)3,
                8
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                3,
                (Disciplina)4,
                7
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                4,
                (Disciplina)5,
                6
            ));
        }
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
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\nDADOS NO SISTEMA\n");

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
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            var alunoSistema = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\nDADOS NO SISTEMA\n");

            Console.WriteLine($"NOME......: {alunoSistema.Nome}");
            Console.WriteLine($"SOBRENOME.: {alunoSistema.Sobrenome}");
            Console.WriteLine($"CPF.......: {alunoSistema.CPF}");
            Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), alunoSistema.Ano)}\n");

            Aluno aluno = criaAluno();

            repositorioAlunos.Atualizar(idAluno, aluno);
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
                Console.WriteLine($"DISCIPLINA...: {(int)n.Disciplina}");
                Console.WriteLine($"1° NOTA: {n.PrimeiraNota}");
                Console.WriteLine($"2° NOTA: {n.SegundaNota}");
                Console.WriteLine($"3° NOTA: {n.TerceiraNota}");
                Console.WriteLine($"4° NOTA: {n.QuartaNota}");
                Console.WriteLine($"MÉDIA..: {n.Media}\n");
            }
        }
        public void InserirNota()
        {
            bool primeira = true;
            int idNota = 0;

            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Console.Write("\n");
            metodosProfessor.ExibeDisciplinas();
            Console.Write("\n");

            Console.Write("Informe a Disciplina da Nota: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPÇÕES");
            Console.WriteLine("1 - PRIMEIRA NOTA");
            Console.WriteLine("2 - SEGUNDA NOTA");
            Console.WriteLine("3 - TERCEIRA NOTA");
            Console.WriteLine("4 - QUARTA NOTA\n");

            Console.Write("Informe a Nota a partir das opções abaixo: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a Nota do Aluno: ");
            double notaInserida = Convert.ToDouble(Console.ReadLine());

            var lista = repositorioNotas.Lista();

            foreach (var nota in lista)
            {
                if (nota.IdAluno == idAluno)
                {
                    if (nota.Disciplina == (Disciplina)disciplina)
                    {
                        idNota = nota.IdNota;
                        primeira = false;
                    }
                }
            }

            if (primeira)
            {
                primeiraNota(idAluno, disciplina, notaInserida);
            }
            else
            {
                atualizaNota(idNota, opcao, notaInserida);
            }

            Console.WriteLine("Nota inserida com sucesso.");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void primeiraNota(int idAluno, int disciplina, double notaInserida)
        {
            Console.WriteLine(repositorioNotas.ProximoId());
            
            Nota nota = new Nota(repositorioNotas.ProximoId(), idAluno, (Disciplina)disciplina, notaInserida);

            repositorioNotas.Inserir(nota);
        }
        public void atualizaNota(int idNota, int opcao, double notaInserida)
        {
            Console.WriteLine("FIRST");

            Nota nota = repositorioNotas.RetornaPorId(idNota);

            switch(opcao)
            {
                case 1:
                    nota.PrimeiraNota = notaInserida;
                    break;
                case 2:
                    nota.SegundaNota = notaInserida;
                    break;
                case 3:
                    nota.TerceiraNota = notaInserida;
                    break;
                case 4:
                    nota.QuartaNota = notaInserida;
                    break;
            }

            repositorioNotas.Atualizar(idNota, nota);
        }
        public void AlteraStatus()
        {
            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Console.WriteLine("\nSITUAÇÃO\n");

            foreach (int i in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Status), i));
            }

            Console.Write("\n");

            Console.Write("Informe a Situação desejada: ");
            int status = Convert.ToInt32(Console.ReadLine());

            var aluno = repositorioAlunos.RetornaPorId(idAluno);

            aluno.alteraStatus(status);

            Console.WriteLine("Status alterado com sucesso.");
        }
    }
}