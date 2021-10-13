namespace sistema_escolar
{
    public class Nota
    {
        public int IdNota { get; protected set; }
        public int IdAluno { get; protected set; }
        public Disciplina Disciplina { get; protected set; }
        public double PriNota { get; protected set; }
        public double SegNota { get; protected set; }
        public double TerNota { get; protected set; }
        public double QuaNota { get; protected set; }
        public double Media { get; protected set; }
        public Nota(int id, int idAluno, Disciplina disciplina)
        {
            this.IdNota = id;
            this.IdAluno = idAluno;
            this.Disciplina = disciplina;
            this.PriNota = -1;
            this.SegNota = -1;
            this.TerNota = -1;
            this.QuaNota = -1;
        }
        public Disciplina retornaDisciplina()
        {
            return this.Disciplina;
        }
    }
}