using System;
using Aula34MVCconsole.Controllers;

namespace Aula34MVCconsole
{
    class Program
    {
        static void Main(string[] args)
        {
             ProdutoControllers prod = new ProdutoControllers();
            //Vai buscar no csv todos os preços que sejam 1200
             prod.Buscar("1200");
        }
    
    }
}
