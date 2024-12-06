using ApiCRUD.Models;
using ApiCRUD.Repositories;
using ApiCRUD.Services;
using Moq;

namespace TestesUnitarios.Services
{
    public class ProdutoServiceTests
    {
        [Fact]
        public void CalcularValorProduto_DeveRetornar_Sucesso()
        {
            //Arrange
            var mockRepositoiProduto = new Mock<IProdutoRepository>();
            mockRepositoiProduto
                .Setup(r => r.ObterProdutoPorId(It.IsAny<int>()))
                .Returns(new Produto { Id = 9, Nome = "Produto Moq", Valor = 85m });

            var repositorioProduto = mockRepositoiProduto.Object;

            var service = new ProdutoService(repositorioProduto);

            //Act
            var valorFinal = service.CalcularValorProduto(9, 0.1m);

            //Assert
            Assert.Equal(76.5m,valorFinal);
        }

        [Fact]
        public void CalcularValorProduto_DeveLancarExcept_QuandoProdutoNaoExiste()
        {
            //Arrange
            var mockRepositoiProduto = new Mock<IProdutoRepository>();
            mockRepositoiProduto
                .Setup(r => r.ObterProdutoPorId(It.IsAny<int>()))
                .Returns((Produto)null);
            
            var repositorioProduto = mockRepositoiProduto.Object;

            var service = new ProdutoService(repositorioProduto);

            //Act & Assert
            Assert.Throws<Exception>(() => service.CalcularValorProduto(9, 0.1m));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1.1)]
        public void CalcuarValorProduto_DeveLancarExcept_QuandoDescontoForInvalido(decimal desconto)
        {
            //Arrange
            var mockRepositoiProduto = new Mock<IProdutoRepository>();
            mockRepositoiProduto
                .Setup(r => r.ObterProdutoPorId(It.IsAny<int>()))
                .Returns(new Produto { Id = 5, Nome = "Novo Produto Moq", Valor = 100m });

            var repositorioProduto = mockRepositoiProduto.Object;

            var service = new ProdutoService(repositorioProduto);

            //Act & Assert
            Assert.Throws<Exception>(() => service.CalcularValorProduto(9, desconto));
        }
    }
}
