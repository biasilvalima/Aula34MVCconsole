using System;
using System.Collections.Generic;
using Aula34MVCconsole.Models;

namespace Aula34MVCconsole.View
{
    public class ProdutoView
    {
        public void MostrarnoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                Console.WriteLine($"{item.Preco} - {item.Nome}");
            }
        }
    }
}