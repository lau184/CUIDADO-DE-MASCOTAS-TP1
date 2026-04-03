using CuidadoMascotas.Utilidades;

public class CalculadoraTests
{
    [Fact]
    public void CalcularCosto_SoloDias()
    {
        var calc = new CalculadoraCosto();

        int resultado = calc.CalcularCosto(2);

        Assert.Equal(1000, resultado);
    }

    [Fact]
    public void CalcularCosto_ConExtra()
    {
        var calc = new CalculadoraCosto();

        int resultado = calc.CalcularCosto(2, 300);

        Assert.Equal(1300, resultado);
    }
}