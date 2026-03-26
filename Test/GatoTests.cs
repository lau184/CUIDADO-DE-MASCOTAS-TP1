using Xunit;
using CuidadoMascotas.Entidades;

public class GatoTests
{
    [Fact]
    public void CrearGato_DeberiaFuncionar()
    {
        Gato gato = new Gato();

        gato.Nombre = "Michi";
        gato.Edad = 2;

        Assert.Equal("Michi", gato.Nombre);
        Assert.Equal(2, gato.Edad);
    }

    [Fact]
    public void MostrarInformacion_NoDebeFallar()
    {
        Gato gato = new Gato();

        var exception = Record.Exception(() => gato.MostrarInformacion());

        Assert.Null(exception);
    }
}