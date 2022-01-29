using sistema_escolar.console.Enum;

namespace sistema_escolar.console.Classes
{
    public class Aluno : Pessoa
    {
        public Ano Ano { get; protected set; }
        public Aluno(int id, string nome, string sobrenome, string cpf, Ano ano)
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
