using BlazorShopAPI.Entidades;
using System.Collections;

namespace BlazorShopAPI.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItem(int id);
        Task<IEnumerable<Produto>> GetItensPorCatergoria(int id);
    }
}
