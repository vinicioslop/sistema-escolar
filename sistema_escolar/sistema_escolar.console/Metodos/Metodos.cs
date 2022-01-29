using sistema_escolar.console.Classes;
using sistema_escolar.console.Classes.Extras;
using sistema_escolar.console.Repositorios;
using sistema_escolar.console.Enum;

namespace sistema_escolar.console.Metodos
{
    public static class Metodos
    {
        // REPOSITÓRIOS
        public static ProfessorRepositorio repositorioProfessores = new ProfessorRepositorio();
        public static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        public static NotaRepositorio repositorioNotas = new NotaRepositorio();

        // INICIA DADOS MOCKADOS DE PROFESSORES, ALUNOS E NOTAS
        public static void IniciaDadosMockados()
        {
            DadosMockados.IniciaDados();

            repositorioProfessores = DadosMockados.repositorioProfessores;
            repositorioAlunos = DadosMockados.repositorioAlunos;
            repositorioNotas = DadosMockados.repositorioNotas;
        }

        // MÉTODOS DE ALUNOS
        public static void CadastrarAluno()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               CADASTRO DE ALUNO                |");
            Console.WriteLine("  +================================================+");

            Aluno aluno = criaAluno();

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                DADOS INFORMADOS                |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  MATRÍCULA: {aluno.Id}");
            Console.WriteLine($"  NOME.....: {aluno.Nome}");
            Console.WriteLine($"  SOBRENOME: {aluno.Sobrenome}");
            Console.WriteLine($"  CPF......: {aluno.CPF}");
            Console.WriteLine($"  ANO......: {System.Enum.GetName(typeof(Ano), aluno.Ano)}");

            repositorioAlunos.Inserir(aluno);
        }
        public static void AtualizarAluno()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |         ATUALIZAÇÃO DE DADOS DE ALUNO          |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe o código de matricula do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este código.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |            DADOS DO ALUNO NO SISTEMA           |");
            Console.WriteLine("  +================================================+\n");

            Console.WriteLine($"  NOME......: {aluno.Nome}");
            Console.WriteLine($"  SOBRENOME.: {aluno.Sobrenome}");
            Console.WriteLine($"  CPF.......: {aluno.CPF}");
            Console.WriteLine($"  ANO.......: {System.Enum.GetName(typeof(Ano), aluno.Ano)}");

            aluno = criaAluno();

            repositorioAlunos.Atualizar(idAluno, aluno);
        }
        public static void InserirNota()
        {
            int idNota = -1;

            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |           INSERÇÃO DE NOTA DE ALUNO            |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe o código de matrícula do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este código.");

            MetodosComplementares.ExibeDisciplinas();

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
                if (nota.IdAluno == idAluno && nota.Disciplina == (Disciplina)disciplina)
                {
                    idNota = nota.Id;
                }
            }

            if (idNota == -1)
            {
                Nota nota = new Nota(
                    repositorioNotas.ProximoId(),
                    idAluno, (Disciplina)disciplina
                );


                repositorioNotas.AdicionaNota(nota.Id, opcao, notaInserida);
                repositorioNotas.Inserir(nota);
            }
            else
            {

                Nota nota = repositorioNotas.RetornaPorId(idNota);

                repositorioNotas.AdicionaNota(nota.Id, opcao, notaInserida);
                repositorioNotas.Atualizar(nota.Id, nota);
            }
        }
        public static void ListarAlunos()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |         LISTAGEM DE ALUNOS CADASTRADOS         |");
            Console.WriteLine("  +================================================+");

            var lista = repositorioAlunos.Lista();

            Console.Write("\n");

            foreach (var aluno in lista)
            {
                Console.Write($"  MATRÍCULA: {aluno.retornaId()} | NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($" | ANO: {aluno.Ano}");
            }

            if (lista.Count == 0)
                throw new Exception("Não há alunos cadastrados.");
        }
        public static void CalcularMedia()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |            CALCULAR MÉDIA DO ALUNO             |");
            Console.WriteLine("  +================================================+");

            if (repositorioNotas.Lista() == null)
            {
                Console.WriteLine("\n  Não há notas cadastradas no sistema.");
                return;
            }

            Console.Write("\n  Informe o código de matrícula do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este código.");

            ListarNota(idAluno);

            Console.Write("\n  Informe a Disciplina referente a Nota do Aluno: ");
            int disciplina = Convert.ToInt32(Console.ReadLine());

            foreach (var nota in repositorioNotas.Lista())
            {
                if (nota.IdAluno == idAluno && nota.Disciplina == (Disciplina)disciplina)
                    repositorioNotas.CalcularMedia(nota.Id);
            }
        }
        public static void ListarAluno()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |           LISTAGEM DE DADOS DO ALUNO           |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Insira o seu código de matrícula do aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            if (repositorioAlunos.RetornaPorId(idAluno) == null)
                throw new Exception("Não há aluno cadastrado com este código.");

            Aluno aluno = repositorioAlunos.RetornaPorId(idAluno);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |            DADOS DO ALUNO NO SISTEMA           |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  NOME......: {aluno.Nome} {aluno.Sobrenome}");
            Console.WriteLine($"  CPF.......: {aluno.CPF}");
            Console.WriteLine($"  ANO.......: {aluno.Ano}\n");

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |           NOTAS DO ALUNO NO SISTEMA            |");
            Console.WriteLine("  +================================================+");

            ListarNota(idAluno);
        }
        public static void ListarNotas()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |               LISTAGEM DE NOTAS                |");
            Console.WriteLine("  +================================================+");

            if (repositorioNotas.Lista().Count == 0)
                throw new Exception("Não há notas cadastrados no sistema.");

            foreach (var nota in repositorioNotas.Lista())
            {
                var aluno = repositorioAlunos.RetornaPorId(nota.IdAluno);

                Console.Write($"  ID: {aluno.Id} | ");
                Console.WriteLine($"  NOME: {aluno.Nome} {aluno.Sobrenome}");
                Console.WriteLine($"  DISCIPLINA: {(int)nota.Disciplina} - {(Disciplina)nota.Disciplina}");
                Console.WriteLine($"  1° NOTA...: {nota.Notas[0]}");
                Console.WriteLine($"  2° NOTA...: {nota.Notas[1]}");
                Console.WriteLine($"  3° NOTA...: {nota.Notas[2]}");
                Console.WriteLine($"  4° NOTA...: {nota.Notas[3]}");
                Console.WriteLine($"  MÉDIA.....: {nota.Notas[5]}");
                Console.WriteLine($"  SITUAÇÃO..: {(Status)nota.Status}\n");
            }
        }
        public static void ListarNota(int idAluno)
        {
            Console.Clear();

            if (idAluno == -1)
            {
                Console.WriteLine("  +================================================+");
                Console.WriteLine("  |           LISTAGEM DE NOTAS DE ALUNO           |");
                Console.WriteLine("  +================================================+");

                Console.Write("\n  Informe o código de matrícula do Aluno: ");
                idAluno = Convert.ToInt32(Console.ReadLine());
            }

            if (repositorioNotas.Lista().Count < 1)
                throw new Exception("Não há notas cadastradas no sistema.");

            var aluno = repositorioAlunos.RetornaPorId(idAluno);

            foreach (var nota in repositorioNotas.Lista())
            {
                if (nota.IdAluno == idAluno)
                {
                    Console.Write($"  ID: {aluno.Id} | ");
                    Console.WriteLine($"  NOME: {aluno.Nome} {aluno.Sobrenome}");
                    Console.WriteLine($"  DISCIPLINA: {(int)nota.Disciplina} - {(Disciplina)nota.Disciplina}");
                    Console.WriteLine($"  1° NOTA...: {nota.Notas[0]}");
                    Console.WriteLine($"  2° NOTA...: {nota.Notas[1]}");
                    Console.WriteLine($"  3° NOTA...: {nota.Notas[2]}");
                    Console.WriteLine($"  4° NOTA...: {nota.Notas[3]}");
                    Console.WriteLine($"  MÉDIA.....: {nota.Notas[5]}");
                    Console.WriteLine($"  SITUAÇÃO..: {(Status)nota.Status}\n");
                }
            }
        }
        static Aluno criaAluno()
        {
            string nome, sobrenome, cpf;
            int ano;

            do
            {
                Console.Write("\n  Digite o Nome.........: ");
                nome = Console.ReadLine();
            } while (MetodosComplementares.VerificaSeNuloS(nome));

            do
            {
                Console.Write("  Digite o Sobrenome....: ");
                sobrenome = Console.ReadLine();
            } while(MetodosComplementares.VerificaSeNuloS(sobrenome));

            do
            {
                Console.Write("  Digite o CPF..........: ");
                cpf = Console.ReadLine();
            } while (MetodosComplementares.VerificaSeNuloS(cpf));

            MetodosComplementares.exibeAnos();

            do
            {
                Console.Write("\n  Escolha o Ano do Aluno: ");
                ano = Convert.ToInt32(Console.ReadLine());
            } while (ano < 1);

            Console.Write("\n");

            return new Aluno(
                id: repositorioAlunos.ProximoId(),
                nome: nome,
                sobrenome: sobrenome,
                cpf: cpf,
                ano: (Ano)ano
            );
        }

        // MÉTODOS DE PROFESSORES
        public static void ListarProfessores()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |             LISTAGEM DE PROFESSORES            |");
            Console.WriteLine("  +================================================+");

            var lista = repositorioProfessores.Lista();

            if (lista.Count == 0)
                throw new Exception("Não há professores cadastrados.");

            Console.Write("\n");

            foreach (var professor in lista)
            {
                Console.Write($"  ID: {professor.Id} | NOME: {professor.Nome} {professor.Sobrenome}");
                Console.WriteLine($" | DISCIPLINA: {professor.Disciplina}");
            }
        }
        public static void ListarProfessor()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |              LISTAGEM DE PROFESSOR             |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Insira o ID do professor: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessores.RetornaPorId(id) == null)
                throw new Exception("Não professor cadastrado com este ID.");

            Professor professor = repositorioProfessores.RetornaPorId(id);

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |                DADOS NO SISTEMA                |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  NOME......: {professor.Nome} {professor.Sobrenome}");
            Console.WriteLine($"  CPF.......: {professor.CPF}");
            Console.WriteLine($"  DISCIPLINA: {professor.Disciplina}");
        }
        public static void CadastrarProfessor()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |              CADASTRO DE PROFESSOR             |");
            Console.WriteLine("  +================================================+");

            Professor professor = criaProfessor();

            repositorioProfessores.Inserir(professor);
        }

        public static void AtualizarProfessor()
        {
            Console.Clear();

            Console.WriteLine("  +================================================+");
            Console.WriteLine("  |            ATUALIZAÇÃO DE PROFESSOR            |");
            Console.WriteLine("  +================================================+");

            Console.Write("\n  Informe o ID do professor: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioProfessores.RetornaPorId(id) == null)
                throw new Exception("Não há professor cadastrado com este ID.");

            var professorSistema = repositorioProfessores.RetornaPorId(id);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                 DADOS INSERIDOS                  |");
            Console.WriteLine("  +================================================+");


            Console.WriteLine($"\n  NOME......: {professorSistema.Nome}");
            Console.WriteLine($"  SOBRENOME.: {professorSistema.Sobrenome}");
            Console.WriteLine($"  CPF.......: {professorSistema.CPF}");
            Console.WriteLine($"  DISCIPLINA: {System.Enum.GetName(typeof(Disciplina), professorSistema.Disciplina)}");

            Professor professor = criaProfessor();

            repositorioProfessores.Atualizar(id, professor);
        }
        static Professor criaProfessor()
        {
            Console.Write("\n");

            string nome, sobrenome, cpf;
            int disciplina;

            do
            {
                Console.Write("\n  Digite o Nome.........: ");
                nome = Console.ReadLine();
            } while (MetodosComplementares.VerificaSeNuloS(nome));

            do
            {
                Console.Write("  Digite o Sobrenome....: ");
                sobrenome = Console.ReadLine();
            } while (MetodosComplementares.VerificaSeNuloS(sobrenome));

            do
            {
                Console.Write("  Digite o CPF..........: ");
                cpf = Console.ReadLine();
            } while (MetodosComplementares.VerificaSeNuloS(cpf));

            MetodosComplementares.ExibeDisciplinas();

            do
            {
                Console.Write("\n  Escolha a Disciplina: ");
                disciplina = Convert.ToInt32(Console.ReadLine());
            } while (disciplina < 1);

            Console.WriteLine("\n  +================================================+");
            Console.WriteLine("  |                 DADOS INSERIDOS                  |");
            Console.WriteLine("  +================================================+");

            Console.WriteLine($"\n  NOME......: {nome}");
            Console.WriteLine($"  SOBRENOME.: {sobrenome}");
            Console.WriteLine($"  CPF.......: {cpf}");
            Console.WriteLine($"  DISCIPLINA: {System.Enum.GetName(typeof(Disciplina), disciplina)}\n");

            return new Professor(
                id: repositorioProfessores.ProximoId(),
                nome: nome,
                sobrenome: sobrenome,
                cpf: cpf,
                disciplina: (Disciplina)disciplina
            );
        }
    }
}
