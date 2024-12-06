using ApiCRUD.Models;

namespace ApiCRUD.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static List<Produto> produtos = new()
        {
            new Produto { Id =1, Nome="Produto teste", Valor=100M },
            new Produto { Id =2, Nome="Outro Produto ", Valor=250M }
        };

        public Produto ObterProdutoPorId(int id)
        {
            return produtos.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
