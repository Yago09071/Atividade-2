﻿using System;

namespace MinhaEmpresa.Produto
{
    public class Produto
    {
        public string Produtos { get; set; }

        public Produto(string product)
        {
            Produtos = product;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {Produtos}");
        }
    }
}