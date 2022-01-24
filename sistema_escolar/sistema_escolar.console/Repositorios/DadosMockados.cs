using sistema_escolar.console.Classes;
using sistema_escolar.console.Classes.Extras;

namespace sistema_escolar.console.Repositorios
{
    public class DadosMockados
    {
        // REPOSITÓRIOS
        public static ProfessorRepositorio repositorioProfessores = new ProfessorRepositorio();
        public static AlunoRepositorio repositorioAlunos = new AlunoRepositorio();
        public static NotaRepositorio repositorioNotas = new NotaRepositorio();

        // INICIA DADOS MOCKADOS
        public static void IniciaDados()
        {
            IniciaProfessoresMockados();
            IniciaAlunosMockados();
            IniciaNotasMockadas();
        }

        // DADOS MOCKADOS DE PROFESSOR
        static void IniciaProfessoresMockados()
        {
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

        // DADOS MOCKADOS DE ALUNOS
        static void IniciaAlunosMockados()
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

        // DADOS MOCKADOS DE NOTAS DE ALUNOS
        static void IniciaNotasMockadas()
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
    }
}
