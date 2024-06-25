using NewBanking.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBanking.Interfaces
{
    public interface IOperacaoBasica
    {
        public bool Saque(decimal value);
        public bool Deposito(decimal value);
        public bool Pagamento(decimal value);
        public bool Transferencia(ContaMolde destino, decimal value);
        public decimal Saldo();
    }
}
