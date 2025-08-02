namespace MAIA.OOP
{
    public class PedidoItem : Entidade
    {
        public string SKU { get; set; }
        public string Fabricante { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public PedidoItem(string categoria) : base(categoria)
        {
            
        }
    }
}
