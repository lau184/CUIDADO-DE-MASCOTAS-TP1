namespace CuidadoMascotas.Entidades
{
    public class Gato : Mascota    //herencia osea q gato hereda de mascota  con sus propiedades y metodos
    {
        public override void MostrarInformacion() //polimorfismo y override (sobreescribir) para q cada mascota muestre su informacion de manera diferente
        {
            Console.WriteLine($"Gato: {Nombre}, Edad: {Edad}"); // muestra el nombre y la edad del gato
        }
    }

}