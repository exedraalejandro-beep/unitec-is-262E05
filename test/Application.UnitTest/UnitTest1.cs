    using Xunit;

public class UnitTestApplication
{
    [Theory]
    [InlineData(2, 2, 2, 8)]
    [InlineData(5, 5, 5, 20)]
    [InlineData(10, 10, 10, 40)]
    public void CalcularPerimetroTrapecio_DatosValidos_Correcto(double lado, double L, double C, double expected)
    {
        double actual = Figura262E05.perimetro(lado, L, C);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 2, 2, 4)]
    [InlineData(5, 5, 5, 5, 25)]
    [InlineData(10, 10, 10, 10, 100)]
    public void CalcularAreaTrapecio_DatosValidos_Correcto(double lado, double altura, double L, double C, double expected)
    {
        double actual = Figura262E05.area(lado, altura, L, C);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 2, 2, 8)]
    [InlineData(3, 3, 3, 3, 27)]
    [InlineData(5, 5, 5, 5, 125)]
    public void CalcularVolumenTrapecio_DatosValidos_Correcto(double lado, double altura, double L, double C, double expected)
    {
        double actual = Figura262E05.volumen(lado, altura, L, C);
        Assert.Equal(expected, actual);
    }
}
