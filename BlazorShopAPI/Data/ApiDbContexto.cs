using Microsoft.EntityFrameworkCore;
namespace BlazorShopAPI.Data
{
    public class ApiDbContexto : DbContext
    {
        public ApiDbContexto(DbContextOptions <ApiDbContexto> options) : base(options)
        {
        }
        
        public DbSet <Entidades.Carrinho>? Carrinhos { get; set; }
        public DbSet <Entidades.CarrinhoItem>? CarrinhoItens { get; set; }
        public DbSet<Entidades.Produto>? Produtos { get; set; }
        public DbSet<Entidades.Categoria>? Categorias { get; set;}
        public DbSet<Entidades.Usuario>? Usuarios { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Categoria>().HasData(new Entidades.Categoria
            {
                Id = 1,
                Nome = "Beleza",
                IconCss = "fas fa-spa"
            });
            modelBuilder.Entity<Entidades.Produto>().HasData(new Entidades.Produto
            {
                Id = 1,
                Nome = "Beleza Kit",
                Descricao = "Kit da oboticário para se sentir fresca até nos dias mais quentes do ano.",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 150,
                Quantidade = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Entidades.Usuario>().HasData(new Entidades.Usuario
            {
                Id = 1,
                NomeUsuario = "Fábio"
            });
        }
    }
}
