// See https://aka.ms/new-console-template for more information
using MAIA.OOP;
using System.Linq;


//Cliente c1 = new Cliente("Premium");
//c1.Nome = "Felipe Maia";
//c1.Id = 2;
//Console.WriteLine(c1);

//Cliente c2 = new Cliente("Excelsior");
//c2.Nome = "Pedro Henrique";
//c2.Id = 2;
//Console.WriteLine(c2);


//Console.WriteLine(c1.Equals(c2));


// O que vai vir da REQUEST - APRESENTACAO ( Pedido Criar Request )


var itendDoPedido = new List<PedidoItem>{ new PedidoItem("Briquedo") { Fabricante = "Estrela", SKU = "XPTOP-100", Quantidade = 1, Valor = 22.50 } };

var pedidoRequest = new PedidoCriarRequest { IdCliente = 1, IdVendedor = 2 , NomeCliente = "Fulano Da Silva" , 
                                             NomeVendedor = "Beltrano Da Rocha", Items = itendDoPedido , ValorPedido = 2203.00 };

Console.WriteLine(pedidoRequest.Items.Count());

var novoItem = new PedidoItem("Celular") { Fabricante = "Xiomi", Quantidade = 2, SKU = "XI08190-55-FF", Valor = 3450.55 };

itendDoPedido.Add(novoItem);

Console.WriteLine(pedidoRequest.Items.Count());


//-----------------------------------------------------------------

var novoItem3 = new PedidoItem("Celular") { Fabricante = "Apple", Quantidade = 2, SKU = "APX90-11-AA", Valor = 9450.55 };
var novoItem4 = new PedidoItem("VideoGame") { Fabricante = "Sony", Quantidade = 4, SKU = "PS0566ER-11-00", Valor = 6000.35 };
var novoItem5 = new PedidoItem("Televesiao") { Fabricante = "Samsung", Quantidade = 5, SKU = "SMG0044555-60-TF", Valor = 2950.55 };


// Adiciona Itens na coleção
itendDoPedido.Add(novoItem3);
itendDoPedido.Add(novoItem4);
itendDoPedido.Add(novoItem5);


Console.WriteLine(pedidoRequest.Items.Count());


// Usa LINQ para iterar na coleção e filtrar pelo Valor 
var itensCaros = pedidoRequest.Items.Where(p => p.Valor > 6000.00).ToList();

// Usa LINQ para iterar na coleção e filtrar pela Categoria
var itensCelulares =  pedidoRequest.Items.Where(c => c.Categoria == "Celular").ToList();

// Usa o ForEach para iterar na coleção
foreach (var iten in itensCaros)
{
    Console.WriteLine(iten.Fabricante + "  --  " + iten.SKU + " --- " + iten.Valor);
}


foreach (var celular in itensCelulares)
{
    Console.WriteLine(celular.Fabricante + "  --  " + celular.SKU + " --- " + celular.Valor);
}



