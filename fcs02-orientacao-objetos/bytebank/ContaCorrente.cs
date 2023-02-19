using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public string numeroAgencia;
        public string conta;
        public string titular;
        public double saldo;

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            return false;
        }
    }
}
