using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Alterar(Produto p);
        void Excluir(Produto p);
        IList<Produto> Listar();
    }
}
