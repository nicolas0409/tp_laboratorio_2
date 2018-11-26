using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Correo c = new Correo();

            Assert.IsNotNull(c.Paquetes);
          
        }
       [ExpectedException(typeof(TrackingRepetidoException))  ]
        [TestMethod]
        public void TestMethod2()
        {
            Correo c = new Correo();
            Paquete p1 = new Paquete("123456", "prueba");
            Paquete p2 = new Paquete("123456", "prueba");


            c += p1;
            c += p2;
           
        }
    }
}
