
namespace CuidadoMascotas.Utilidades
{
    public class CalculadoraCosto
    {
        public int CalcularCosto(int dias) //metodo para calcular el costo del cuidado de la mascota segun los dias de cuidado
        {
            return dias * 500;    //retorna el costo total multiplicando los dias por 500, que es el costo diario del cuidado de la mascota
        }

        public int CalcularCosto(int dias, int extra)        //sobrecraga  
        {                                                   // permite calcular el costo total incluyendo un costo extra, por ejemplo
            return (dias * 500) + extra;                   //retorna el costo total multiplicando los dias por 500 y sumando el costo extras
        }
    }
}