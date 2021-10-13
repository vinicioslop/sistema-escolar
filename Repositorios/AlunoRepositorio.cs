using System;
using System.Collections.Generic;
using sistema_escolar.Interfaces;

namespace sistema_escolar.Repositorios
{
    public class AlunoRepositorio : IRepositorio<Aluno>
    {
        private List<Aluno> listaAluno = new List<Aluno>();
        public void Atualizar(int id, Aluno aluno)
        {
            listaAluno[id] = aluno;
        }
        public void Inserir(Aluno aluno)
        {
            listaAluno.Add(aluno);
        }
        public List<Aluno> Lista()
        {
            return listaAluno;
        }
        public int ProximoId()
        {
            return listaAluno.Count;
        }
        public Aluno RetornaPorId(int id)
        {
            return listaAluno[id];
        }
    }
}