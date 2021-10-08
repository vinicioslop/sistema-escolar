namespace sistema_escolar
{
    public class Nota
    {
        public int IdAluno { get; set; }
        private Disciplina Disciplina { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }
        public double QuartaNota { get; set; }
        public double Media { get; set; }

        public Nota(int id, Disciplina disciplina)
        {
            this.IdAluno = id;
            this.Disciplina = disciplina;
        }
        public void InserirNota(int opcao, double nota)
        {
            switch (opcao)
            {
                case 1:
                    this.PrimeiraNota = nota;
                    break;
                case 2:
                    this.SegundaNota = nota;
                    break;
                case 3:
                    this.TerceiraNota = nota;
                    break;
                case 4:
                    this.QuartaNota = nota;
                    break;
                default:
                    break;
            }
        }
        public double retornaPrimeiraNota()
        {
            return this.PrimeiraNota;
        }
        public double retornaSegundaNota()
        {
            return this.SegundaNota;
        }
        public double retornaTerceiraNota()
        {
            return this.TerceiraNota;
        }
        public double retornaQuartaNota()
        {
            return this.QuartaNota;
        }
        public double retornaMedia()
        {
            return this.Media;
        }
    }
}