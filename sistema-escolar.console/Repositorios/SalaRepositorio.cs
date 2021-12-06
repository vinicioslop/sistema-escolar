using System.Collections.Generic;
using sistema_escolar.console.Interfaces;

namespace sistema_escolar.console.Repositorios
{
    public class SalaRepositorio : IRepositorio<Sala>
    {
        private List<Sala> listaSala = new List<Sala>();
        public void Atualizar(int id, Sala sala)
        {
            listaSala[id] = sala;
        }
        public void Inserir(Sala sala)
        {
            listaSala.Add(sala);
        }
        public List<Sala> Lista()
        {
            return listaSala;
        }
        public int ProximoId()
        {
            return listaSala.Count;
        }
        public Sala RetornaPorId(int id)
        {
            return listaSala[id];
        }
    }
}