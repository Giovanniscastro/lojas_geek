namespace lojas_geek.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome {get; set;}
        public string Cnpj { get; set;}

        public string Endereco { get; set;} 
        public string Email { get; set;}

        public string Telefone { get; set;}
        ICollection<Produto> ProdutoList { get; set;} = new List<Produto>();
    }
}
