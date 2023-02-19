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
        public double saldo = 100.0;

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            return false;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > 0 && valor <= this.saldo)
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
