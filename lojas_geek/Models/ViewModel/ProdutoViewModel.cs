namespace lojas_geek.Models.ViewModel
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
        public ICollection<Fornecedor> FornecedorList { get; set; } = new List<Fornecedor>();
        public int Id { get; internal set; }
    }
}
