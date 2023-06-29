namespace lojas_geek.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Datavenda { get; set; }
        //public string Produto { get; set; }
        //public string   Cliente { get; set;}
        public string Endereco { get; set; }

        public int DadosPagId { get; set; }
        public DadosPag DadosPagamento { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<Produto> Produtos { get; } = new List<Produto>();
    }    
}
