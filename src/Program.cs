using CuidadoMascotas.Entidades;
using CuidadoMascotas.Servicios;

// 1. Primero creas el servicio de cuidado (que implementa ICuidado)
var miServicio = new CuidadoBasico();

// 2. Creas al perro y LE PASAS el servicio por el constructor (como pide tu código)
var miPerro = new Perro(miServicio);

// 3. (Opcional) Si quieres que tenga nombre, asígnale valores a las propiedades
miPerro.Nombre = "Fido";
miPerro.Edad = 3;

// 4. Llamas al método correcto que definiste en tu clase Perro
miPerro.MostrarInformacion();
miPerro.RealizarCuidado();

Console.WriteLine("Proceso finalizado.");