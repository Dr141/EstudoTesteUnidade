using NewBanking.Interfaces;

namespace NewBanking.Modelos
{
    public class ContaMolde : IOperacaoBasica
    {
        private int _agencia;
        private int _conta;
        private int _dvConta;
        private decimal _saldo;

        public ContaMolde(int agencia, int conta, int dv_conta, decimal saldo = 0) => 
            (_agencia, _conta, _dvConta, _saldo) = (agencia, conta, dv_conta, saldo);

        public bool Deposito(decimal value)
        {
            if (value > 0)
            {
                _saldo += value;
                return true;
            }

            throw new ArgumentOutOfRangeException($"Valor menor ou igual a zero. Deposito de R$ {value}");
        }

        public bool Pagamento(decimal value)
        {
            return SaqueOrPagamento(value);
        }

        public decimal Saldo()
        {
            return _saldo; 
        }

        public bool Saque(decimal value)
        {
            return SaqueOrPagamento(value);
        }

        public bool Transferencia(ContaMolde destino, decimal value)
        {
            if (destino is null) throw new NullReferenceException("Conta não inicializada.");
            if (SaqueOrPagamento(value)) destino.Deposito(value);
            return true;
        }

        private bool SaqueOrPagamento(decimal value)
        {
            if (_saldo >= value)
            {
                _saldo -= value;
                return true;
            }

            throw new ArgumentOutOfRangeException($"Saldo insuficiente. Saldo atual R$ {_saldo}, falta R$ {(value - _saldo)}\npara transação se concluída com sucesso");
        }

        public override string ToString()
        {
            return 
                $@"Agencia: {_agencia}
                   Conta: {_conta} - {_dvConta}
                   Saldo: R$ {_saldo}";
        }
    }
}
