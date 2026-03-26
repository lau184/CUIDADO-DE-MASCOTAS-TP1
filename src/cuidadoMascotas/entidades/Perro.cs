using CuidadoMascotas.Contratos;

namespace CuidadoMascotas.Entidades
{
    public class Perro : Mascota
    {
        private ICuidado cuidado;

        public Perro(ICuidado cuidado)
        {
            this.cuidado = cuidado;
        }

        public void RealizarCuidado()
        {
            cuidado.Cuidar();
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Perro: {Nombre}, Edad: {Edad}");
        }
    }
}