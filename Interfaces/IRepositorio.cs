using System.Collections.Generic;

namespace sistema_escolar.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId();
        void Inserir(T entidade);
        void Atualizar(int id, T entidade);
        void ProximoId();
    }
}