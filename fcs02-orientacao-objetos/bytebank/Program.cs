using bytebank;

ContaCorrente contaDoFulano = new ContaCorrente();

contaDoFulano.numeroAgencia = "0900";
contaDoFulano.conta = "1010-9";
contaDoFulano.titular = "Fulano de Tal";
contaDoFulano.saldo = 100.0;

Console.WriteLine($"O saldo da conta de {contaDoFulano.titular} é {contaDoFulano.saldo.ToString("c")}");