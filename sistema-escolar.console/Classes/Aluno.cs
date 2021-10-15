namespace sistema_escolar.console
{
    public class Aluno : EntidadeBase
    {
        public Ano Ano { get; protected set; }
        public Aluno (int id, string nome, string sobrenome, string cpf, Ano ano)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Ano = ano;
        }
        public int retornaId()
        {
            return this.Id;
        }
    }
}