using System.Collections.Generic;
using sistema_escolar.Interfaces;

namespace sistema_escolar.Classes.Repositorios
{
    public class ProfessorRepositorio : IRepositorio<Professor>
    {
        private List<Professor> listaProfessor = new List<Professor>();
        public void Atualizar(int id, Professor professor)
        {
            listaProfessor[id] = professor;
        }

        public void Inserir(Professor professor)
        {
            listaProfessor.Add(professor);
        }

        public List<Professor> Lista()
        {
            return listaProfessor;
        }

        public int ProximoId()
        {
            return listaProfessor.Count;
        }

        public Professor RetornaPorId(int id)
        {
            return listaProfessor[id];
        }
    }
}