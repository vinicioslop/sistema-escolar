namespace sistema_escolar
{
    public class Professor : EntidadeBase
    {
        private Disciplina Disciplina { get; set; }

        public Professor(int id, string nome, string sobrenome, string cpf, Disciplina disciplina)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.Disciplina = disciplina;
        }

        public string retornaNome()
        {
            return this.Nome;
        }
        public string retornaSobrenome()
        {
            return this.Sobrenome;
        }
        public Disciplina retornaDisciplina()
        {
            return this.Disciplina;
        }
    }
}