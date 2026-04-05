using System;
using CuidadoMascotas.Contratos;

namespace CuidadoMascotas.Servicios
{
    public class CuidadoPremium : ICuidado
    {
        public void Cuidar()
        {
            Console.WriteLine("Cuidado premium incluye: baño, paseo , comida especial y atención personalizada.");
        }
    }
}