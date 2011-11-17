using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Digital
{
    [TestClass]
    public class DigitalTeste
    {
        [TestMethod]
        public void DigitalizarNumero1()
        {
            Assert.AreEqual(@"   
  |
  |", new Digitalizador().Digitalizar(1));
        }
        [TestMethod]
        public void DigitalizarNumero2()
        {
            Assert.AreEqual(
@" _ 
 _|
|_ ", new Digitalizador().Digitalizar(2));
        }

        [TestMethod]
        public void DigitalizarNumero11()
        {
            Assert.AreEqual(
@"       
  |   |
  |   |", new Digitalizador().Digitalizar(11));
        }

        [TestMethod]
        public void DigitalizarNumero111()
        {
            Assert.AreEqual(
@"           
  |   |   |
  |   |   |", new Digitalizador().Digitalizar(111));
        }
        [TestMethod]
        public void DigitalizarNumero1234()
        {
            Assert.AreEqual(
@"     _   _     
  |  _|  _| |_|
  | |_   _|   |", new Digitalizador().Digitalizar(1234));
        }

    }
}
