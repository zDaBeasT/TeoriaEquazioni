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
            double esponente = 2;
            bool ValoreAspettato = true;
            bool Risultato = Equazioni.IsDegree(esponente);
            Assert.AreEqual(ValoreAspettato, Risultato);
        }
        [TestMethod]
        public void IsDegree2falso()
        {
            double esponente = 3;
            bool ValoreAspettato = false;
            bool Risultato = Equazioni.IsDegree(esponente);
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
        public void SoluzioniTest()
        {
            double a = 2, b = 4, c = 0;
            string valoreAspettato = "Le soluzioni sono: x1 = 0; x2 = -2";
            string valoreRitorno = Equazioni.Soluzioni(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void EquationDegree1Test()
        {
            double a = 2, b = 4;
            string valoreAspettato = "Il risultato dell'equazione è: 2";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void EquationDegree2Test()
        {
            double a = 1, b = 2, c = 3;
            string valoreAspettato = "Non ci sono soluzioni";
            string valoreRitorno = Equazioni.EquationDegree2(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
    }
}
