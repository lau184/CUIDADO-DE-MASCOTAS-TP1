using Xunit;
using System;

namespace Test
{
    public class ProgramTests
    {
        [Fact]
        public void Main_NoDeberiaFallar()
        {
                                             //stringwriter es una clase que permite escribir en un string en lugar de la consola
            var output = new StringWriter(); //cree un StringWriter para capturar la salida de la consola durante la prueba
            Console.SetOut(output); //setout redirecciona la salida de la consola a un StringWriter para capturar el output del programa durante la prueba

       
            var exception = Record.Exception(() => Program.Main([])); 
                                //Record.Exception es un método de xUnit que ejecuta el código proporcionado y captura cualquier excepción que se lance durante su ejecución
                                //En este caso, se esta ejecutando el método Main del programa con un array vacío como argumento.
            
            Assert.Null(exception);
        }
    }
}