using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntitiy();
            AtualizarDados();
            RecuperarDados();
            //ExluirDados();

            Console.ReadKey();
        }

        private static void GravarUsandoEntitiy()
        {

            Produto p1 = new Produto();
            p1.Nome = "Harry Potter e a Ordem da Fênix";
            p1.Categoria = "Livros";
            p1.Preco = 19.89;

            Produto p2 = new Produto();
            p2.Nome = "Anjos e Demonios";
            p2.Categoria = "Livros";
            p2.Preco = 59.89;

            Produto p3 = new Produto();
            p3.Nome = "Box contos Nordicos";
            p3.Categoria = "Livros";
            p3.Preco = 69.89;


            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p1);
            }

        }
        private static void RecuperarDados()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Listar(); 

                foreach(var p in produtos)
                {
                    Console.WriteLine(p.Nome);
                }
            }
        }
        private static void ExluirDados()
        {
            using (var contexto = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = contexto.Listar();
                foreach (var p in produtos)
                {
                    contexto.Excluir(p);
                }
            }
        }
        private static void AtualizarDados()
        {
            using (var contexto = new ProdutoDAOEntity())
            {

                Produto p = contexto.Listar().First();
                p.Nome = "As cronicas de Narnia";
                contexto.Alterar(p);

            }
        }
        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }

        }
    }
}
