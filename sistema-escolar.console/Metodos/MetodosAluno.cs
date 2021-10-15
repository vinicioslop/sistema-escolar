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
                (Disciplina)1
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                1,
                (Disciplina)2
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                2,
                (Disciplina)3
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                3,
                (Disciplina)4
            ));
            repositorioNotas.Inserir(new Nota(
                repositorioNotas.ProximoId(),
                4,
                (Disciplina)5
            ));
        }
        public void CadastrarAluno()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE ALUNO\n");

            Console.Write("Digite o Nome.........: ");
            string nomeE = Console.ReadLine();

            Console.Write("Digite o Sobrenome....: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("Digite o CPF..........: ");
            string cpfE = Console.ReadLine();

            Console.WriteLine("\nANOS\n");

            exibeAnos();

            Console.Write("\n");

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

            Aluno aluno = new Aluno(
                id: repositorioAlunos.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                ano: (Ano)anoE
            );

            repositorioAlunos.Inserir(aluno);
        }
        public void AtualizarAluno()
        {
            Console.Clear();
            Console.WriteLine("ATUALIZAÇÃO DE ALUNO\n");

            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\nDADOS NO SISTEMA\n");

            Console.WriteLine($"NOME......: {aluno.Nome}");
            Console.WriteLine($"SOBRENOME.: {aluno.Sobrenome}");
            Console.WriteLine($"CPF.......: {aluno.CPF}");
            Console.WriteLine($"ANO.......: {Enum.GetName(typeof(Ano), aluno.Ano)}\n");

            Console.WriteLine("\nInforme os dados do Aluno\n");
            Console.Write($"NOME......: ");
            string nome = Console.ReadLine();

            Console.Write($"SOBRENOME.: ");
            string sobrenome = Console.ReadLine();

            Console.Write($"CPF.......: ");
            string cpf = Console.ReadLine();

            Console.Write("\n");
            exibeAnos();

            Console.Write($"\nANO.......: ");

            repositorioAlunos.Atualizar(idAluno, aluno);
        }
        public void InserirNota()
        {
            Console.Clear();
            Console.WriteLine("INSERÇÃO DE NOTA DE ALUNO\n");

            bool primeira = true;
            int idNota = 0;

            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Console.WriteLine("Dados no Sistema\n");

            listaNotaAluno(idAluno);

            Console.WriteLine("Deseja inserir uma nova nota?");

            Console.Write("(S)im, (N)ão: ");
            string novaNota = Console.ReadLine();

            if (novaNota.ToUpper() == "S")
            {
                Console.Write("\n");
                metodosProfessor.ExibeDisciplinas();
                Console.Write("\n");
            }

            Console.Write("Informe a Disciplina da Nota: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOPÇÕES");
            Console.WriteLine("1 - PRIMEIRA NOTA");
            Console.WriteLine("2 - SEGUNDA NOTA");
            Console.WriteLine("3 - TERCEIRA NOTA");
            Console.WriteLine("4 - QUARTA NOTA\n");

            Console.Write("Informe a Nota a partir das opções acima: ");
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
                Nota nota = new Nota(
                    repositorioNotas.ProximoId(),
                    idAluno, (Disciplina)disciplina
                );
                nota.InsereNota(1, notaInserida);

                repositorioNotas.Inserir(nota);
            }
            else
            {
                atualizaNota(idNota, opcao, notaInserida);
            }

            Console.WriteLine("\nNota inserida com sucesso.");

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void ListarAlunos()
        {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE ALUNOS\n");

            var lista = repositorioAlunos.Lista();

            foreach (var aluno in lista)
            {
                Console.Write($"ID: {aluno.retornaId()} | NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($" | ANO: {aluno.Ano}");
            }

            if (lista.Count == 0)
                throw new Exception("Não há alunos cadastrados.");
        }
        public void CalculaMedia()
        {
            Console.Clear();
            Console.WriteLine("CALCULAR MEDIA DO ALUNO\n");

            var listaNotas = repositorioNotas.Lista();

            if (listaNotas == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Console.Write("\n");
            listaNotaAluno(idAluno);
            Console.Write("\n");

            Console.Write("Informe a Disciplina da Nota do Aluno: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            foreach (var n in listaNotas)
            {
                if (n.IdAluno == idAluno && n.Disciplina == (Disciplina)disciplina)
                    n.CalculaMedia();
            }
        }
        public void ListarAluno()
        {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE ALUNO\n");

            Console.Write("Insira o seu ID: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.Clear();

            Console.WriteLine("\nDADOS NO SISTEMA\n");
            Console.WriteLine($"NOME......: {aluno.Nome} {aluno.Sobrenome}");
            Console.WriteLine($"CPF.......: {aluno.CPF}");
            Console.WriteLine($"ANO.......: {aluno.Ano}\n");

            Console.WriteLine("NOTAS DO ALUNO NO SISTEMA\n");
            
            listaNotaAluno(idAluno);

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void ListarNotas()
        {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE NOTAS\n");

            var listaNotas = repositorioNotas.Lista();

            if (listaNotas == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            foreach (var n in listaNotas)
            {
                var aluno = repositorioAlunos.RetornaPorId(n.IdAluno);

                Console.Write($"ID: {aluno.Id} | ");
                Console.WriteLine($"NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($"DISCIPLINA: {(int)n.Disciplina} - {(Disciplina)n.Disciplina}");
                Console.WriteLine($"1° NOTA...: {n.PrimeiraNota}");
                Console.WriteLine($"2° NOTA...: {n.SegundaNota}");
                Console.WriteLine($"3° NOTA...: {n.TerceiraNota}");
                Console.WriteLine($"4° NOTA...: {n.QuartaNota}");
                Console.WriteLine($"MÉDIA.....: {n.Media}");
                Console.WriteLine($"SITUAÇÃO..: {(Status)n.Status}\n");
            }
        }
        public void ListarNota()
        {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE NOTA\n");

            Console.Write("Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            listaNotaAluno(idAluno);

            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        public void exibeAnos()
        {
            foreach (int i in Enum.GetValues(typeof(Ano)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Ano), i));
            }
        }
        public void listaNotaAluno(int idAluno)
        {
            bool existe = false;

            var aluno = repositorioAlunos.RetornaPorId(idAluno);
            var listaNotas = repositorioNotas.Lista();

            foreach (var n in listaNotas)
            {
                if (n.IdAluno == idAluno)
                {
                    existe = true;

                    Console.WriteLine($"DISCIPLINA...: {(int)n.Disciplina} - {n.Disciplina}");
                    Console.WriteLine($"1ª NOTA: {n.PrimeiraNota}");
                    Console.WriteLine($"2ª NOTA: {n.SegundaNota}");
                    Console.WriteLine($"3ª NOTA: {n.TerceiraNota}");
                    Console.WriteLine($"4ª NOTA: {n.QuartaNota}");
                    Console.WriteLine($"MÉDIA..: {n.Media}");
                }
            }

            if (!existe)
                Console.WriteLine("Não há notas cadastradas para este aluno.");
        }
        public void atualizaNota(int idNota, int opcao, double notaInserida)
        {
            Nota nota = repositorioNotas.RetornaPorId(idNota);

            nota.InsereNota(opcao, notaInserida);

            repositorioNotas.Atualizar(idNota, nota);
        }
    }
}