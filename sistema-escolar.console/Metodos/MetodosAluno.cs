using System;
using sistema_escolar.console.Repositorios;

namespace sistema_escolar.console.Metodos
{
    public class MetodosAluno
    {
        static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        static NotaRepositorio repositorioNotas = new NotaRepositorio();
        MetodosProfessor metodosProfessor = new MetodosProfessor();
        MetodosEnum metodosEnum = new MetodosEnum();
        public void IniciaAlunosMockados()
        {
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

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               CADASTRO DE ALUNO                |");
            Console.WriteLine("  +================================================+");

            Aluno aluno = criaAluno();

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                DADOS INSERIDOS                 |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  ID.......: {aluno.Id}");
            Console.WriteLine($"  NOME.....: {aluno.Nome}");
            Console.WriteLine($"  SOBRENOME: {aluno.Sobrenome}");
            Console.WriteLine($"  CPF......: {aluno.CPF}");
            Console.WriteLine($"  ANO......: {Enum.GetName(typeof(Ano), aluno.Ano)}");

            repositorioAlunos.Inserir(aluno);
        }
        public void AtualizarAluno()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |              ATUALIZAÇÃO DE ALUNO              |");
            Console.WriteLine("  +================================================+");


            Console.Write("\n  Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                DADOS NO SISTEMA                |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  NOME......: {aluno.Nome}");
            Console.WriteLine($"  SOBRENOME.: {aluno.Sobrenome}");
            Console.WriteLine($"  CPF.......: {aluno.CPF}");
            Console.WriteLine($"  ANO.......: {Enum.GetName(typeof(Ano), aluno.Ano)}");

            aluno = criaAluno();

            repositorioAlunos.Atualizar(idAluno, aluno);
        }
        public void InserirNota()
        {
            bool primeira = true;
            int idNota = 0;

            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |           INSERÇÃO DE NOTA DE ALUNO            |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                DADOS NO SISTEMA                |");
            Console.WriteLine("  +================================================+");

            listaNotasAluno(idAluno);

            Console.WriteLine("\n  Deseja inserir uma nova Nota com outra Disciplina?");
            Console.Write("  (S)im, (N)ão: ");
            string novaNota = Console.ReadLine();

            if (novaNota.ToUpper() == "S")
                metodosEnum.ExibeDisciplinas();

            Console.Write("\n  Informe a Disciplina da Nota: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                     OPÇÕES                     |");
            Console.WriteLine("  +================================================+");
            Console.WriteLine("  | 1 - PRIMEIRA NOTA                              |");
            Console.WriteLine("  | 2 - SEGUNDA NOTA                               |");
            Console.WriteLine("  | 3 - TERCEIRA NOTA                              |");
            Console.WriteLine("  | 4 - QUARTA NOTA                                |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe qual nota quer alterar ou inserir: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n  Informe a Nota: ");
            double notaInserida = Convert.ToDouble(Console.ReadLine());

            var listaNotas = repositorioNotas.Lista();

            foreach (var nota in listaNotas)
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

            Console.WriteLine("\n  Nota inserida com sucesso.");
            EsperaTecla();
        }
        public void ListarAlunos()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               LISTAGEM DE ALUNOS               |");
            Console.WriteLine("  +================================================+");

            var lista = repositorioAlunos.Lista();

            Console.Write("\n");
            
            foreach (var aluno in lista)
            {
                Console.Write($"  ID: {aluno.retornaId()} | NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($" | ANO: {aluno.Ano}");
            }

            if (lista.Count == 0)
                throw new Exception("Não há alunos cadastrados.");
        }
        public void CalcularMedia()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |            CALCULAR MEDIA DO ALUNO             |");
            Console.WriteLine("  +================================================+");

            if (repositorioNotas.Lista() == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            Console.Write("\n  Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            listaNotasAluno(idAluno);

            Console.Write("\n  Informe a Disciplina da Nota do Aluno: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            var listaNotas = repositorioNotas.Lista();

            foreach (var n in listaNotas)
            {
                if (n.IdAluno == idAluno && n.Disciplina == (Disciplina)disciplina)
                    n.CalcularMedia();
            }
        }
        public void ListarAluno()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               LISTAGEM DE ALUNO                |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Insira o seu ID: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este ID.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                DADOS NO SISTEMA                |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  NOME......: {aluno.Nome} {aluno.Sobrenome}");
            Console.WriteLine($"  CPF.......: {aluno.CPF}");
            Console.WriteLine($"  ANO.......: {aluno.Ano}\n");

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |           NOTAS DO ALUNO NO SISTEMA            |");
            Console.WriteLine("  +================================================+");

            listaNotasAluno(idAluno);
        }
        public void ListarNotas()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               LISTAGEM DE NOTAS                |");
            Console.WriteLine("  +================================================+");

            listaNotas();
        }
        public void ListarNota()
        {
            Console.Clear();
            
            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |                LISTAGEM DE NOTA                |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            listaNotasAluno(idAluno);
        }
        public Aluno criaAluno()
        {
            Console.Write("\n  Digite o Nome.........: ");
            string nomeE = Console.ReadLine();

            Console.Write("  Digite o Sobrenome....: ");
            string sobrenomeE = Console.ReadLine();

            Console.Write("  Digite o CPF..........: ");
            string cpfE = Console.ReadLine();

            metodosEnum.exibeAnos();

            Console.Write("\n  Escolha o Ano do Aluno: ");
            int anoE = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            return new Aluno(
                id: repositorioAlunos.ProximoId(),
                nome: nomeE,
                sobrenome: sobrenomeE,
                cpf: cpfE,
                ano: (Ano)anoE
            );
        }
        public void listaNotas()
        {
            Console.Write("\n");

            if (repositorioNotas.Lista() == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            var listaNotas = repositorioNotas.Lista();

            foreach (var n in listaNotas)
            {
                var aluno = repositorioAlunos.RetornaPorId(n.IdAluno);

                Console.Write($"  ID: {aluno.Id} | ");
                Console.WriteLine($"  NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($"  DISCIPLINA: {(int)n.Disciplina} - {(Disciplina)n.Disciplina}");
                Console.WriteLine($"  1° NOTA...: {n.PrimeiraNota}");
                Console.WriteLine($"  2° NOTA...: {n.SegundaNota}");
                Console.WriteLine($"  3° NOTA...: {n.TerceiraNota}");
                Console.WriteLine($"  4° NOTA...: {n.QuartaNota}");
                Console.WriteLine($"  MÉDIA.....: {n.Media}");
                Console.WriteLine($"  SITUAÇÃO..: {(Status)n.Status}\n");
            }
        }
        public void listaNotasAluno(int idAluno)
        {
            bool existe = false;

            var aluno = repositorioAlunos.RetornaPorId(idAluno);

            if (repositorioNotas.Lista() == null)
                throw new Exception("Não há notas cadastradas no sistema.");

            var listaNotas = repositorioNotas.Lista();

            Console.Write("\n");

            foreach (var n in listaNotas)
            {
                if (n.IdAluno == idAluno)
                {
                    existe = true;

                    Console.WriteLine($"  DISCIPLINA: {(int)n.Disciplina} - {n.Disciplina}");
                    Console.WriteLine($"  1ª NOTA...: {n.PrimeiraNota}");
                    Console.WriteLine($"  2ª NOTA...: {n.SegundaNota}");
                    Console.WriteLine($"  3ª NOTA...: {n.TerceiraNota}");
                    Console.WriteLine($"  4ª NOTA...: {n.QuartaNota}");
                    Console.WriteLine($"  MÉDIA.....: {n.Media}");
                }
            }

            if (!existe)
                Console.WriteLine("  Não há notas cadastradas para este aluno.");
        }
        public void atualizaNota(int idNota, int opcao, double notaInserida)
        {
            Nota nota = repositorioNotas.RetornaPorId(idNota);

            nota.InsereNota(opcao, notaInserida);

            repositorioNotas.Atualizar(idNota, nota);
        }
        static void EsperaTecla()
        {
            Console.Write("\n  Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}