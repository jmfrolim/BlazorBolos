﻿namespace BlazorBolos.Data
{
    public class Bolo
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set; }

        public decimal Preco { get; set; }
    }
}
