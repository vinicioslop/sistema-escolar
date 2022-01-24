namespace sistema_escolar.console.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Inserir(T entidade);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
