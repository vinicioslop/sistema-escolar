namespace sistema_escolar.console
{
    public class Professor : EntidadeBase
    {
        public Disciplina Disciplina { get; protected set; }
        public Professor(int id, string nome, string sobrenome, string cpf, Disciplina disciplina)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Disciplina = disciplina;
        }
    }
}