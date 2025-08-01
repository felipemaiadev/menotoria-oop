// See https://aka.ms/new-console-template for more information
using MAIA.OOP;


Cliente c1 = new Cliente("Premium");
c1.Nome = "Felipe Maia";
c1.Id = 2;
Console.WriteLine(c1);

Cliente c2 = new Cliente("Excelsior");
c2.Nome = "Pedro Henrique Cardoso";
c2.Id = 2;
Console.WriteLine(c2);


Console.WriteLine(c1.Equals(c2));