using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 4;
            bool ValoreAspettato = true;
            bool ValoreRitorno = Equazioni.IsDetermined(a);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void IsDeterminedTest1()
        {
            double a = 0;
            bool ValoreAspettato = false;
            bool ValoreRitorno = Equazioni.IsDetermined(a);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void IsInconsistedTest1()
        {
            double a = 5, b = 3;
            bool ValoreAspettato = false;
            bool ValoreRitorno = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 0, b = 5;
            bool ValoreAspettato = true;
            bool ValoreRitorno = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(ValoreAspettato, ValoreRitorno);

        }
        [TestMethod]
        public void IsDegree2()
        {
            double a = 3, b = 2;
            bool ValoreAspettato = true;
            bool Risultato = Equazioni.IsDegree(b);
            Assert.AreEqual(ValoreAspettato, Risultato);
        }
        [TestMethod]
        public void Delta()
        {
            double a = 3, b = 2, c = 4;
            double ValoreAspettato = -44;
            double Risultato = Equazioni.Delta(a, b, c);
            Assert.AreEqual(ValoreAspettato, Risultato);
        }
        [TestMethod]
        public void Delta1()
        {
            double a = 1, b = 2, c = 1;
            double ValoreAspettato = 0;
            double Risultato = Equazioni.Delta(a, b, c);
            Assert.AreEqual(ValoreAspettato, Risultato);
        }
        [TestMethod]
        public void TestEquazioneSecondoCompleta()
        {
            double a = 1, b = 2, c = 3;
            string valoreAspettato = "Non ci sono soluzioni";
            string valoreRitorno = Equazioni.Eq2Grado(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
    }
}
