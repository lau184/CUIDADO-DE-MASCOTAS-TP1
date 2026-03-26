
namespace CuidadoMascotas.Utilidades
{
    public class CalculadoraCosto
    {
        public int CalcularCosto(int dias)
        {
            return dias * 500;
        }

        public int CalcularCosto(int dias, int extra)
        {
            return (dias * 500) + extra;
        }
    }
}