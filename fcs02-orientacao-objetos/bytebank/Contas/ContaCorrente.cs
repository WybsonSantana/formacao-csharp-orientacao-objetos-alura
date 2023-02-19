﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
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
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > 0 && valor <= saldo)
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
                $"\nDados pessoais:\nTitular: {titular.nome}\nCPF: {titular.cpf}\nProfissão: {titular.profissao}\n" +
                $"\nDados da conta:\nAgência: {numeroAgencia}\nConta: {conta}\nSaldo: {saldo.ToString("c")}";
        }
    }
}