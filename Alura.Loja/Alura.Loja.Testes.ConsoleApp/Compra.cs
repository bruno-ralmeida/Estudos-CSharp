namespace Alura.Loja.Testes.ConsoleApp
{
    internal class Compra
    {
        public int id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quatidade { get; set; }
        public double Preco { get; internal set; }
    }
}