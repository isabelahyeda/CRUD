using projetocrud.Interfaces;

namespace projetocrud
{
    public class ClienteRepositorio : IRepositorio<Cliente>

    {
        private List<Cliente> listaclientes = new List<Cliente>();

        public void Atualizar(int id, Cliente entidade)
        {
            listaclientes[id] = entidade;
        }

        public void Excluir(int id, Cliente entidade)
        {
           
           
           listaclientes[id].Excluido = true;
           
        }

        public void Inserir(Cliente entidade)
        {
            entidade.id = listaclientes.Count;
            
            listaclientes.Add(entidade);
        }

        public List<Cliente> Lista()
        {
           return listaclientes;
        }

        public int ProximoId()
        {
            return listaclientes.Count;
        }

        public Cliente RetornarPorId(int id)
        {
            return listaclientes[id];
        }
    }
}