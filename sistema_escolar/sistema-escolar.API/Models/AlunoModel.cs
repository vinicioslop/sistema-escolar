using sistema_escolar.console.Classes;
using sistema_escolar.console;

namespace sistema_escolar.API.Models
{
    public class AlunoModel : Pessoa
    {
        public Ano Ano { get; protected set; }
        public AlunoModel() { }
        public AlunoModel(Aluno aluno)
        {
            this.Id = aluno.Id;
            this.Nome = aluno.Nome;
            this.Sobrenome = aluno.Sobrenome;
            this.CPF = aluno.CPF;
            this.Ano = aluno.Ano;
        }
        public Aluno ToAluno()
        {
            return new Aluno(Id, Nome, Sobrenome, CPF, Ano);
        }
    }
}
