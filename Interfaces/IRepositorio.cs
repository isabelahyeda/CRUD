namespace projetocrud.Interfaces
{
    public interface IRepositorio<T>
    {
    List<T> Lista();

    T RetornarPorId (int id);
    void Inserir(T entidade);
    void Atualizar(int id, T entidade);
    void Excluir(int id, T entidade);
    int ProximoId();

    }
}