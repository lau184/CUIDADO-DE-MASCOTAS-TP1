using System;

namespace CuidadoMascotas.Entidades
{
    public abstract class Mascota
    {
        public string Nombre { get; set; } = ""; 
        public int Edad { get; set; }

        public abstract void MostrarInformacion();
    }
}