using sistema_escolar.console;
using sistema_escolar.console.Classes.Extras;

namespace sistema_escolar.API.Models
{
    public class NotaModel
    {
        public double[] Notas = new double[5];

        public int Id { get; protected set; }
        public int IdAluno { get; protected set; }
        public Disciplina Disciplina { get; protected set; }
    }
}
