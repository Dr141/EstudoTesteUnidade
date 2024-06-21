namespace MatematicaTest
{
    using Calculadora;

    [TestClass]
    public class CalculoTeste
    {
        [TestMethod]
        [Timeout(1)]
        public void Adicao()
        {
            Matematica matematica = new Matematica();
            decimal resultado = matematica.Adicao(10, 10);
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void Subtracao()
        {
            Matematica matematica = new Matematica();
            decimal resultado = matematica.Subtracao(10, 2);
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Multiplicacao() 
        { 
            Matematica matematica = new Matematica();
            decimal resultado = matematica.Multiplicacao(10, 2);
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void Divisao()
        {
            Matematica matematica = new Matematica();
            decimal resultado = matematica.Divisao(10, 2);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Potencia()
        {
            Matematica matematica = new Matematica();
            decimal resultado = matematica.Potencia(4, 2);
            Assert.AreEqual(16, resultado);
        }

        [TestMethod]
        public void Multiplicacao_Decimal()
        {
            Matematica ma = new Matematica();
            decimal resultado = ma.Multiplicacao(2.5m, 2.5m);
            Assert.AreEqual(6.25m, resultado);
        }

        [TestMethod]
        public void Divisao_Decimal()
        {
            Matematica ma = new Matematica();
            decimal resultado = ma.Divisao(6.25m, 2.5m);
            Assert.AreEqual(2.5m, resultado);
        }

        [TestMethod]
        public void Divisao_Por_Zero()
        {
            Matematica ma = new Matematica();
            Assert.ThrowsException<System.DivideByZeroException>(() => ma.Divisao(0, 0));
        }
    }
}