using CuidadoMascotas.Utilidades;

public class CalculadoraTests
{
    [Fact]
    public void CalcularCosto_SoloDias()
    {
        var calc = new CalculadoraCosto();               //crea una instancia de la clase CalculadoraCosto para poder llamar a sus métodos

        int resultado = calc.CalcularCosto(2);      //llama al método CalcularCosto con 2 días de cuidado y almacena el resultado

        Assert.Equal(1000, resultado);                       //verifica que el resultado sea igual a 1000
                                                             // que es el costo esperado para 2 días de cuidado (2 * 500)
    }

    [Fact]
    public void CalcularCosto_ConExtra()
    {
        var calc = new CalculadoraCosto();

        int resultado = calc.CalcularCosto(2, 300);        //llama al método CalcularCosto con 2 días de cuidado y un costo extra de 300
                                                     
        Assert.Equal(1300, resultado);               //verifica que el resultado sea igual a 1300, que es el costo esperado para 2 días de cuidado (2 * 500) más el costo extra de 300
    }
}