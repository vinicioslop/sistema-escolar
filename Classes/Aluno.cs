namespace sistema_escolar
{
    public class Aluno : EntidadeBase
    {
        private Ano Ano { get; set; }
        private Nota Nota { get; set; }
        private Status Status { get; set; }
    }
}