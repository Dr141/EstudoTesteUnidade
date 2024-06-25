namespace NewBanking.Modelos.Tests
{
    [TestClass()]
    public class ContaMoldeTests
    {
        [TestMethod()]
        public void PagamentoTest()
        {
            ContaMolde conta = new ContaMolde(1, 1, 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Pagamento(30));
        }

        [TestMethod()]
        public void DepositoTest()
        {
            ContaMolde conta = new ContaMolde(1, 1, 0);
            Assert.IsTrue(conta.Deposito(30));
            Assert.AreEqual(30, conta.Saldo());
        }

        [TestMethod()]
        public void SaldoTest()
        {
            ContaMolde conta = new ContaMolde(1, 1, 0);
            Assert.IsNotNull(conta.Saldo());
        }

        [TestMethod()]
        public void SaqueTest()
        {
            ContaMolde conta = new ContaMolde(1, 1, 1, 100);
            Assert.IsTrue(conta.Saque(30));
            Assert.AreEqual(70, conta.Saldo());
        }

        [TestMethod()]
        public void TransferenciaTest()
        {
            ContaMolde contaOrigem = new ContaMolde(1, 1, 1, 100);
            ContaMolde contaDestino = new ContaMolde(1, 1, 1, 150);
            Assert.IsTrue(contaOrigem.Transferencia(contaDestino, 50));

            if(contaOrigem.Saldo() != 50) Assert.Fail();
            if(contaDestino.Saldo() != 200) Assert.Fail();            
        }
    }
}