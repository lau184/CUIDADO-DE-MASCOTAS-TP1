using CuidadoMascotas.Entidades;
using CuidadoMascotas.Servicios;
using CuidadoMascotas.Contratos; // Agrega esta línea

// 1. Creas el servicio
var miServicio = new CuidadoBasico();

// 2. Creas al perro pasandole el servicio
var miPerro = new Perro(miServicio)
{
    Nombre = "Fido",
    Edad = 3
};

// 3. Ejecutas
miPerro.MostrarInformacion();
miPerro.RealizarCuidado();

Console.WriteLine("Proceso finalizado.");