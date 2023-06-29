namespace lojas_geek.Models
{
    public class ProdutoVenda
    {
        public int Id { get; set; }

        public int QuantProduto { get; set; }
        public double Valor { get; set; }

        // ligação com a tabela de produtos
        public int ProdutoId { get; set; }        
        public Produto? Produto { get; set; }
        public int VendaId { get; set; }        
        public Venda? Venda { get; set; }
    }
}
