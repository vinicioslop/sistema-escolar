using sistema_escolar.console.Classes.Extras;
using sistema_escolar.console.Interfaces;

namespace sistema_escolar.console.Repositorios
{
    public class NotaRepositorio : IRepositorio<Nota>
    {
        private List<Nota> listaNota = new List<Nota>();
        public void Atualizar(int id, Nota nota)
        {
            listaNota[id] = nota;
        }
        public void Inserir(Nota nota)
        {
            listaNota.Add(nota);
        }
        public List<Nota> Lista()
        {
            return listaNota;
        }
        public int ProximoId()
        {
            return listaNota.Count;
        }
        public Nota RetornaPorId(int id)
        {
            return listaNota[id];
        }
    }
}
