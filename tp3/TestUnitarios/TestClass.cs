using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class TestClass
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void Test_NullInsertException()
        {
            Afiliado afiliado = new Afiliado();

            AccesoDatos.GuardarAfiliado(afiliado);
        }

        [TestMethod]
        public void Test_InsertOk()
        {
            Afiliado afiliado = new Afiliado("testApellido", "testNombre", 12345678, "test@gmail.com", 424511, true);

            Assert.AreEqual(AccesoDatos.GuardarAfiliado(afiliado), 1);
        }
    }
}
