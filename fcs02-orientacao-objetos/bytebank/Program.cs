using bytebank;

ContaCorrente contaDoFulano = new ContaCorrente();
contaDoFulano.numeroAgencia = "0900";
contaDoFulano.conta = "1010-9";
contaDoFulano.titular = "Fulano de Tal";
//contaDoFulano.saldo = 100.0;

ContaCorrente contaDoBeltrano = new ContaCorrente();
contaDoBeltrano.numeroAgencia = "0900";
contaDoBeltrano.conta = "2115-5";
contaDoBeltrano.titular = "Bel Trano";
//contaDoBeltrano.saldo = 300.0;

Console.WriteLine($"O saldo da conta de {contaDoFulano.titular} é {contaDoFulano.saldo.ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.titular} é {contaDoBeltrano.saldo.ToString("c")}");

double valorDeposito = 300.0;
Console.WriteLine($"\nDepositando {valorDeposito.ToString("c")} na conta de {contaDoFulano.titular}...");
if (contaDoFulano.Depositar(valorDeposito))
{
    Console.WriteLine("Depósito realizado com sucesso!");
}
else
{
    Console.WriteLine("Depósito não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.titular} é {contaDoFulano.saldo.ToString("c")}");

double valorSaque = 150.00;
Console.WriteLine($"\nSacando {valorSaque.ToString("c")} na conta de {contaDoFulano.titular}...");
if (contaDoFulano.Sacar(valorSaque))
{
    Console.WriteLine("Saque realizado com sucesso!");
}
else
{
    Console.WriteLine("Saque não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.titular} é {contaDoFulano.saldo.ToString("c")}");

double valorTransferencia = 80.0;
string pagador = contaDoBeltrano.titular;
string beneficiario = contaDoFulano.titular;

Console.WriteLine($"\nTransferindo {valorTransferencia.ToString("c")} da conta de {pagador} para a conta de {beneficiario}...");
if (contaDoBeltrano.Transferir(valorTransferencia, contaDoFulano))
{
    Console.WriteLine("Transferência realizada com sucesso!");
}
else
{
    Console.WriteLine("Transferência não realizada!");
}

Console.WriteLine($"\nO saldo da conta de {contaDoFulano.titular} é {contaDoFulano.saldo.ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.titular} é {contaDoBeltrano.saldo.ToString("c")}");