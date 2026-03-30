namespace CuidadoMascotas.Entidades
{
    public class Gato : Mascota
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gato: {Nombre}, Edad: {Edad}");
        }
    }

}