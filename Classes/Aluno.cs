namespace sistema_escolar
{
    public class Aluno : EntidadeBase
    {
        private Ano Ano { get; set; }
        private Nota Nota { get; set; }
        private Status Status { get; set; }

        public Aluno (int id, string nome, string sobrenome, string cpf, Ano ano, Nota nota, Status status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Ano = ano;
            this.Nota = nota;
            this.Status = status;
        }

        public string retornaNome()
        {
            return this.Nome;
        }
        public string retornaSobrenome()
        {
            return this.Sobrenome;
        }
        public Ano retornaAno()
        {
            return this.Ano;
        }
        public Nota retornaNota()
        {
            return this.Nota;
        }
        public Status retornaStatus()
        {
            return this.Status;
        }
    }
}