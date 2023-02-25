using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao { get; set; }

        private int _numeroAgencia;

        public int NumeroAgencia
        {
            get { return this._numeroAgencia; }
            private set
            {
                if (value > 0)
                {
                    this._numeroAgencia = value;
                }
            }
        }

        public string Conta { get; set; }

        private double _saldo = 100.0;

        public Cliente Titular { get; set; }

        public ContaCorrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;

            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero", nameof(numeroAgencia));
            }

            this.Conta = conta;

            /*
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ops! Algo deu errado! Não é possível dividir por zero.");
            }
            */
            TotalDeContasCriadas++;
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
