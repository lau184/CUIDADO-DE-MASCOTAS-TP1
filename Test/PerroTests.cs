using Xunit;
using CuidadoMascotas.Entidades;
using CuidadoMascotas.Servicios;
using CuidadoMascotas.Contratos;

public class PerroTests
{
    [Fact]
    public void CrearPerro_DeberiaAsignarNombreYEdad()
    {
        ICuidado cuidado = new CuidadoBasico();
        Perro perro = new Perro(cuidado);

        perro.Nombre = "Luna";
        perro.Edad = 3;

        Assert.Equal("Luna", perro.Nombre);
        Assert.Equal(3, perro.Edad);
    }

    [Fact]
    public void RealizarCuidado_NoDeberiaFallar()
    {
        ICuidado cuidado = new CuidadoPremium();
        Perro perro = new Perro(cuidado);

        var exception = Record.Exception(() => perro.RealizarCuidado());

        Assert.Null(exception);
    }
}