using CuidadoMascotas.Entidades;
using CuidadoMascotas.Servicios;

// 1. Creas el servicio
var miServicio = new CuidadoPremium();

// 2. Creas al perro y le asignas las propiedades dentro de las llaves
var miPerro = new Perro(miServicio)
{
    Nombre = "Fido",
    Edad = 3
};

// 3. Ejecutas los métodos
miPerro.MostrarInformacion();
miPerro.RealizarCuidado();

Console.WriteLine("Proceso finalizado.");