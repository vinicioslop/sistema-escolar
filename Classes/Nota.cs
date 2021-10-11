namespace sistema_escolar
{
    public class Nota
    {
        public int IdNota { get; set; }
        public int IdAluno { get; set; }
        private Disciplina Disciplina { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }
        public double QuartaNota { get; set; }
        public double Media { get; set; }

        public Nota(int id, int idAluno, Disciplina disciplina)
        {
            this.IdNota = id;
            this.IdAluno = idAluno;
            this.Disciplina = disciplina;
            this.PrimeiraNota = -1;
            this.SegundaNota = -1;
            this.TerceiraNota = -1;
            this.QuartaNota = -1;
        }
        public Disciplina retornaDisciplina()
        {
            return this.Disciplina;
        }
    }
}