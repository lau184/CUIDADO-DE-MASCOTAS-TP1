using Xunit;
using CuidadoMascotas.Servicios;

public class CuidadoTests
{
    [Fact]
    public void CuidadoBasico_NoDebeFallar()
    {
        var cuidado = new CuidadoBasico();

        var exception = Record.Exception(() => cuidado.Cuidar());  //registra cualquier excepción que pueda ocurrir al llamar al método Cuidar del cuidado básico

        Assert.Null(exception);              //verifica que no se haya lanzado ninguna excepción, lo que indica que el método Cuidar del cuidado básico funciona correctamente sin errores
    }

    [Fact]
    public void CuidadoPremium_NoDebeFallar()
    {
        var cuidado = new CuidadoPremium();

        var exception = Record.Exception(() => cuidado.Cuidar());

        Assert.Null(exception);
    }
}