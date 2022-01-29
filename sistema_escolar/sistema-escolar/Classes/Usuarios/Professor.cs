namespace sistema_escolar.console.Classes
{
    public class Professor : Pessoa
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
