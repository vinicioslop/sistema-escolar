namespace sistema_escolar.console
{
    public class Sala
    {
        public string Id { get; set; }
        public char Letra { get; set; }
        public Ano Ano { get; set; }
        public int NumeroAlunos { get; set; }

        public Sala (string id, char letra, Ano ano, int numeroAlunos)
        {
            this.Id = id;
            this.Letra = letra;
            this.Ano = ano;
            this.NumeroAlunos = numeroAlunos;
        }
    }
}