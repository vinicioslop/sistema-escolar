namespace sistema_escolar
{
    public class Aluno : EntidadeBase
    {
        public Ano Ano { get; protected set; }
        public Status Status { get; protected set; }

        public Aluno (int id, string nome, string sobrenome, string cpf, Ano ano)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Ano = ano;
            this.Status = Status.CURSANDO;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void alteraStatus(int status)
        {
            this.Status = (Status)status;
        }
    }
}