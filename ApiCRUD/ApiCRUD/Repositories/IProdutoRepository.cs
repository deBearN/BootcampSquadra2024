using ApiCRUD.Models;

namespace ApiCRUD.Repositories
{
    public interface IProdutoRepository
    {
        Produto ObterProdutoPorId(int id);
    }
}
