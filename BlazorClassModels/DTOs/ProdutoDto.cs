﻿namespace BlazorClassModels.DTOs
{
    internal class ProdutoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; } = string.Empty;
        public string? ImagemUrl { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public string? NomeCategoria { get; set; }
    }
}
