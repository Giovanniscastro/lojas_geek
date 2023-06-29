namespace lojas_geek.Models
{
    public class Produto
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
       public string Descricao { get; set; }

       public double Valor { get; set; }

        public int Quantidade { get; set; }

        public int FornecedorId { get; set; }
        public  Fornecedor Fornecedor{ get; set; }

        public List<Venda> Vendas { get; } = new List<Venda>();
    }
}