using CuidadoMascotas.Entidades;
using CuidadoMascotas.Servicios;

public class Program
{
    public static void Main(string[] args)  
    {
        var miServicio = new CuidadoPremium();  //instancia del servicio de cuidado premium

        var miPerro = new Perro(miServicio)  //
        {
            Nombre = "Fido",
            Edad = 3
        };

        miPerro.MostrarInformacion();
        miPerro.RealizarCuidado();

        Console.WriteLine("Proceso finalizado.");
    }
}