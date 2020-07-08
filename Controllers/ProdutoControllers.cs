using System.Collections.Generic;
using Aula34MVCconsole.Models;
using Aula34MVCconsole.View;

namespace Aula34MVCconsole.Controllers
{
    public class ProdutoControllers
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            produtoView.MostrarnoConsole(produtoModel.Ler());
        }

        public void Buscar(string _preco)
        {
            
            List<Produto> busca = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarnoConsole( busca);
        }
    }
}