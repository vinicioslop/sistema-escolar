namespace sistema_escolar.console
{
    public class Nota
    {
        public int IdNota { get; protected set; }
        public int IdAluno { get; protected set; }
        public Disciplina Disciplina { get; protected set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }
        public double QuartaNota { get; set; }
        public double Media { get; protected set; }
        public Nota(int id, int idAluno, Disciplina disciplina, double primeiraNota)
        {
            this.IdNota = id;
            this.IdAluno = idAluno;
            this.Disciplina = disciplina;
            this.PrimeiraNota = primeiraNota;
        }
        public void CalculaMedia()
        {
            this.Media = (
                this.PrimeiraNota + 
                this.SegundaNota + 
                this.TerceiraNota + 
                this.QuartaNota) / 4;
        }
    }
}