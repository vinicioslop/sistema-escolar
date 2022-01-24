namespace sistema_escolar.console.Classes.Extras
{
    public class Nota
    {
        public int Id { get; protected set; }
        public int IdAluno { get; protected set; }
        public Disciplina Disciplina { get; protected set; }
        public double PrimeiraNota { get; protected set; }
        public double SegundaNota { get; protected set; }
        public double TerceiraNota { get; protected set; }
        public double QuartaNota { get; protected set; }
        public double Media { get; protected set; }
        public Status Status { get; protected set; }
        public Nota(int id, int idAluno, Disciplina disciplina)
        {
            this.Id = id;
            this.IdAluno = idAluno;
            this.Disciplina = disciplina;
        }
        public void InsereNota(int opcao, double nota)
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
                    throw new System.Exception("Opção de nota inválida.");
            }
        }
        public void CalcularMedia()
        {
            this.Media = (
                this.PrimeiraNota +
                this.SegundaNota +
                this.TerceiraNota +
                this.QuartaNota) / 4;

            DefineStatus();
        }
        public void DefineStatus()
        {
            if (this.Media <= 5.4)
            {
                this.Status = Status.REPROVADO;
            }
            else if (this.Media <= 6.9)
            {
                this.Status = Status.RECUPERACAO;
            }
            else
            {
                this.Status = Status.APROVADO;
            }
        }
    }
}
