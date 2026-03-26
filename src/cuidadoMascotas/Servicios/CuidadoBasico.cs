using System;
using CuidadoMascotas.Contratos;

namespace CuidadoMascotas.Servicios
{
    public class CuidadoBasico : ICuidado
    {
        public void Cuidar()
        {
            Console.WriteLine("Cuidado básico: comida y agua");
        }
    }
}