using ComissaoVendas.Models;
using ComissaoVendas.Services;

namespace ComissaoVendas.Tests.Services;

public class ComissaoServiceTests
{
[Fact]
public void DeveRetornarZeroQuandoVendaForMenorQue100()
{
// Arrange
var service = new ComissaoService();

    // Act
    var resultado = service.CalcularComissaoVenda(50);

    // Assert
    Assert.Equal(0m, resultado);
}

[Fact]
public void DeveCalcular1PorCentoQuandoVendaEstiverEntre100E499()
{
    // Arrange
    var service = new ComissaoService();

    // Act
    var resultado = service.CalcularComissaoVenda(200);

    // Assert
    Assert.Equal(2m, resultado);
}

[Fact]
public void DeveCalcular5PorCentoQuandoVendaFor500OuMais()
{
    // Arrange
    var service = new ComissaoService();

    // Act
    var resultado = service.CalcularComissaoVenda(1000);

    // Assert
    Assert.Equal(50m, resultado);
}

[Fact]
public void DeveCalcular1PorCentoQuandoVendaForExatamente100()
{
    // Arrange
    var service = new ComissaoService();

    // Act
    var resultado = service.CalcularComissaoVenda(100);

    // Assert
    Assert.Equal(1m, resultado);
}

[Fact]
public void DeveCalcular5PorCentoQuandoVendaForExatamente500()
{
    // Arrange
    var service = new ComissaoService();

    // Act
    var resultado = service.CalcularComissaoVenda(500);

    // Assert
    Assert.Equal(25m, resultado);
}

[Fact]
public void DeveCalcularComissaoPorVendedor()
{
    // Arrange
    var service = new ComissaoService();

    var vendas = new List<Venda>
    {
        new Venda
        {
            Vendedor = "Maria",
            Valor = 200
        },
        new Venda
        {
            Vendedor = "Maria",
            Valor = 1000
        },
        new Venda
        {
            Vendedor = "Joao",
            Valor = 500
        }
    };

    // Act
    var resultado = service.CalcularComissaoPorVendedor(vendas);

    // Assert
    Assert.Equal(2, resultado.Count);

    var maria = resultado.First(v => v.Vendedor == "Maria");
    var joao = resultado.First(v => v.Vendedor == "Joao");

    Assert.Equal(52m, maria.Comissao);
    Assert.Equal(25m, joao.Comissao);
}

[Fact]
public void DeveRetornarListaVaziaQuandoNaoHouverVendas()
{
    // Arrange
    var service = new ComissaoService();

    var vendas = new List<Venda>();

    // Act
    var resultado = service.CalcularComissaoPorVendedor(vendas);

    // Assert
    Assert.Empty(resultado);
}

}
