using BlazorShopAPI.Data;
using BlazorShopAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApiDbContexto _contexto;

        public ProdutoRepository(ApiDbContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<Produto> GetItem(int id)
        {
            var produto = await _contexto.Produtos
                .Include(c => c.Categoria)
                .SingleOrDefaultAsync(c  => c.Id == id);

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetItens()
        {
            var produtos = await _contexto.Produtos
                .Include(p => p.Categoria)
                .ToListAsync();

            return produtos;
        }

        public async Task<IEnumerable<Produto>> GetItensPorCatergoria(int id)
        {
            var produtos = await _contexto.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.CategoriaId == id).ToListAsync();

            return produtos;
        }
    }
}
