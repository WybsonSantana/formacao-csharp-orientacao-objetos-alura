using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private string _numeroAgencia = "0900";

        public string NumeroAgencia
        {
            get { return this._numeroAgencia; }
            private set
            {
                if (value == "" || value == null)
                {
                    this._numeroAgencia = "0900";
                }
                else
                {
                    this._numeroAgencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double _saldo = 100.0;

        public Cliente Titular { get; set; }

        public ContaCorrente(string numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                return true;
            }
            return false;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo)
            {
                _saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > 0 && valor <= _saldo)
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            return false;
        }

        public string exibirDados()
        {
            return $"\nInformações do cliente\n" +
                $"\nDados pessoais:\nTitular: {Titular.Nome}\nCPF: {Titular.CPF}\nProfissão: {Titular.Profissao}\n" +
                $"\nDados da conta:\nAgência: {_numeroAgencia}\nConta: {Conta}\nSaldo: {_saldo.ToString("c")}";
        }

        public void GetSaldo(double valor)
        {
            if (valor >= 0)
            {
                this._saldo = valor;
            }
            return;
        }

        public double GetSaldo()
        {
            return this._saldo;
        }
    }
}
