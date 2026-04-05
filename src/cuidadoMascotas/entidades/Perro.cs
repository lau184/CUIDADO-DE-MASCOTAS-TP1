using CuidadoMascotas.Contratos;

namespace CuidadoMascotas.Entidades
{
    public class Perro : Mascota //herencia
    {
        private ICuidado cuidado; //depende de la interfaz cuidado para realizar
                                  //el cuidado del perro, esto es inyeccion de dependencia

        public Perro(ICuidado cuidado)          //inyeccion de dependencia , mira el constructor de laclase
        {                                       //recibe como inyectando cualquier objeto que implemente la interfaz ICuidado
            this.cuidado = cuidado;
        }

        public void RealizarCuidado()       //metodo para realizar el cuidado del perro
        {
            cuidado.Cuidar();               //llama justamente a  funcion cuidar q esta en Icuidado
        }

        public override void MostrarInformacion()     //polimorfismo para mostrar la informacion del perro de manera diferente a otras mascotas
        {
            Console.WriteLine($"Perro: {Nombre}, Edad: {Edad}");
        }
    }
}