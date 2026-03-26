using Xunit;
using CuidadoMascotas.Servicios;

public class CuidadoTests
{
    [Fact]
    public void CuidadoBasico_NoDebeFallar()
    {
        var cuidado = new CuidadoBasico();

        var exception = Record.Exception(() => cuidado.Cuidar());

        Assert.Null(exception);
    }

    [Fact]
    public void CuidadoPremium_NoDebeFallar()
    {
        var cuidado = new CuidadoPremium();

        var exception = Record.Exception(() => cuidado.Cuidar());

        Assert.Null(exception);
    }
}