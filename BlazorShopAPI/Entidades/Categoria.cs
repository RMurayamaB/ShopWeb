﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorShopAPI.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;
        public string IconCss { get; set; } = string.Empty;

        public Collection<Produto> Produtos { get; set; } = new Collection<Produto>();
    }
}
