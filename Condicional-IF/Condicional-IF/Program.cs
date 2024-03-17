// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Cliente Especial (S/N)");
var cliente = Console.ReadLine();

if(cliente == "S" || cliente == "s")
{
    Console.WriteLine("\nCliente especial");
}
else
{
    Console.WriteLine("\nCliente não especial");
}
