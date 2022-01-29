using sistema_escolar.console.Classes;
using sistema_escolar.console;

namespace sistema_escolar.API.Models
{
    public class ProfessorModel : Pessoa
    {
        public Disciplina Disciplina { get; protected set; }
        public ProfessorModel() { }
        public ProfessorModel(Professor professor)
        {
            this.Id = professor.Id;
            this.Nome = professor.Nome;
            this.Sobrenome = professor.Sobrenome;
            this.CPF = professor.CPF;
            this.Disciplina = professor.Disciplina;
        }
        public Professor ToProfessor(Professor professor)
        {
            return new Professor(Id, Nome, Sobrenome, CPF, Disciplina);
        }
    }
}
