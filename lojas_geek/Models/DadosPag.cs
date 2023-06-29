namespace lojas_geek.Models
{
    public class DadosPag 
    {
        public int Id { get; set; }
        public Type Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public Venda Venda { get; set; }  
      
    }

    public enum Type : int
    {

        Pix = 0,
        Boleto = 1,
        Debito = 2,
        Credito = 3
    }


}
