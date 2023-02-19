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
        public double saldo = 100.0;
        public Cliente titular;

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

        public string exibirDados()
        {
            return $"\nInformações do cliente\n" +
                $"\nDados pessoais:\nTitular: {this.titular.nome}\nCPF: {this.titular.cpf}\nProfissão: {this.titular.profissao}\n" +
                $"\nDados da conta:\nAgência: {this.numeroAgencia}\nConta: {this.conta}\nSaldo: {this.saldo.ToString("c")}";
        }
    }
}
