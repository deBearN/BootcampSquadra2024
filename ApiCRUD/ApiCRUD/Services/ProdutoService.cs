using ApiCRUD.Models;
using ApiCRUD.Repositories;

namespace ApiCRUD.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto ObterProdutoPorId(int id)
        {
            ////controller
            //try
            //{
            //    return Ok(Produto);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.message)
            //}

            var produto = _produtoRepository.ObterProdutoPorId(id);

            if (produto == null)
                throw new Exception("Produto não encontrado");

            return produto;
        }

        public decimal CalcularValorProduto(int produtoId, decimal desconto)
        {
            var produto = _produtoRepository.ObterProdutoPorId(produtoId);

            if (produto == null)
                throw new Exception("Produto não encontrado");

            if (desconto < 0 || desconto > 1)
                throw new Exception("O desconto deve estar entre 0 e 1.");

            return produto.Valor * (1 - desconto);
        }
    }
}
