using sistema_escolar.console.Enum;

namespace sistema_escolar.console.Classes.Extras
{
    public class Nota
    {
        public double[] Notas = new double[5];

        public int Id { get; protected set; }
        public int IdAluno { get; protected set; }
        public Disciplina Disciplina { get; protected set; }
        public Status Status { get; protected set; }
        public Nota(int id, int idAluno, Disciplina disciplina)
        {
            this.Id = id;
            this.IdAluno = idAluno;
            this.Disciplina = disciplina;
        }

        public void AlteraStatus(Status status)
        {
            this.Status = status;
        }
    }
}
