using Xunit;
using System;

namespace Test
{
    public class ProgramTests
    {
        [Fact]
        public void Main_NoDeberiaFallar()
        {
            
            var output = new StringWriter();
            Console.SetOut(output);

       
            var exception = Record.Exception(() => Program.Main([]));

            
            Assert.Null(exception);
        }
    }
}