using System;

namespace API.Models
{
    public class MeioPgto
    {
        public MeioPgto() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        // public Produto Produto { get; set; }
        // public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Prazo { get; set; }
        // public string CarrinhoId { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}