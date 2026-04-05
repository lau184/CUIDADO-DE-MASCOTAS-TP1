using System;

namespace CuidadoMascotas.Entidades
{
    public abstract class Mascota    //clase abstracta osea q no se puede instanciar directamente
    {
        //enccapsulamiento 
        public string Nombre { get; set; } = ""; 
        public int Edad { get; set; }     // doble encapsulamiento 

        public abstract void MostrarInformacion(); //metodo abstracto para q cada mascota implemente su propia forma de mostrar informacion
    }
}