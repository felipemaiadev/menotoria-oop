namespace MAIA.OOP
{
    public class PedidoCriarRequest
    {
        public int IdVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public double ValorPedido { get; set; }
        public IEnumerable<PedidoItem> Items { get; set; }
    }
}
