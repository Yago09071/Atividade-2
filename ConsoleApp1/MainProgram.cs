using MinhaEmpresa.Cliente;
using MinhaEmpresa.Produto;
using System;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Sigmeyer of catarina", "sigmeyer.catarina@exemple.com");
        Produto produto = new Produto("cebola");

        Console.WriteLine($"Cliente: {cliente.Nome} \nEmail: {cliente.Email} \nProduto: {produto.Produtos}");
    }
}