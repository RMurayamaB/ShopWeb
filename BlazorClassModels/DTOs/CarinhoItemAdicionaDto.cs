using System.ComponentModel.DataAnnotations;

namespace BlazorClassModels.DTOs
{
    internal class CarinhoItemAdicionaDto
    {
        [Required]
        public int CarrinhoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int Quantidade { get; set; }
    }
}
