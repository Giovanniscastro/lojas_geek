namespace lojas_geek.Models
{
    public class Cliente
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        
        public string Cpf { get; set; }    
        public DateTime Data_nasc { get; set; }
        public string Telefone { get; set; }

        public string Email { get; set; }
      ICollection<Cliente> ClienteList { get; set; } = new List<Cliente>();
    }
}
