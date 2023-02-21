using bytebank.Contas;
using bytebank.Titular;

Cliente fulano = new Cliente();
fulano.Nome = "Fulano de Tal";
fulano.CPF = "164.144.010-48";
fulano.Profissao = "Analista Jr";

ContaCorrente contaDoFulano = new ContaCorrente(numeroAgencia: "0900", conta: "1010-9");
contaDoFulano.Titular = fulano;

Cliente beltrano = new Cliente();
beltrano.Nome = "Bel Trano";
beltrano.CPF = "596.966.280-13";
beltrano.Profissao = "Analista PL";

ContaCorrente contaDoBeltrano = new ContaCorrente(numeroAgencia: "0900", conta: "2115-5");
contaDoBeltrano.Titular = beltrano;

Console.WriteLine($"O saldo da conta de {contaDoFulano.Titular.Nome} é {contaDoFulano.GetSaldo().ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.Titular.Nome} é {contaDoBeltrano.GetSaldo().ToString("c")}");

double valorDeposito = 300.0;
Console.WriteLine($"\nDepositando {valorDeposito.ToString("c")} na conta de {contaDoFulano.Titular.Nome}...");
if (contaDoFulano.Depositar(valorDeposito))
{
    Console.WriteLine("Depósito realizado com sucesso!");
}
else
{
    Console.WriteLine("Depósito não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.Titular.Nome} é {contaDoFulano.GetSaldo().ToString("c")}");

double valorSaque = 150.00;
Console.WriteLine($"\nSacando {valorSaque.ToString("c")} na conta de {contaDoFulano.Titular.Nome}...");
if (contaDoFulano.Sacar(valorSaque))
{
    Console.WriteLine("Saque realizado com sucesso!");
}
else
{
    Console.WriteLine("Saque não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.Titular.Nome} é {contaDoFulano.GetSaldo().ToString("c")}");

double valorTransferencia = 80.0;
string pagador = contaDoBeltrano.Titular.Nome;
string beneficiario = contaDoFulano.Titular.Nome;

Console.WriteLine($"\nTransferindo {valorTransferencia.ToString("c")} da conta de {pagador} para a conta de {beneficiario}...");
if (contaDoBeltrano.Transferir(valorTransferencia, contaDoFulano))
{
    Console.WriteLine("Transferência realizada com sucesso!");
}
else
{
    Console.WriteLine("Transferência não realizada!");
}

Console.WriteLine($"\nO saldo da conta de {contaDoFulano.Titular.Nome} é {contaDoFulano.GetSaldo().ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.Titular.Nome} é {contaDoBeltrano.GetSaldo().ToString("c")}\n");

double valor1 = 300.0;
double valor2 = valor1;
Console.WriteLine(valor1 == valor2);
Console.WriteLine(valor1);
Console.WriteLine(valor2);

Cliente fulano2 = new Cliente();
fulano2.Nome = "Fulano de Tal";
fulano2.CPF = "164.144.010-48";
fulano2.Profissao = "Analista Jr";

ContaCorrente contaDoFulano2 = new ContaCorrente(numeroAgencia: "0900", conta: "1010-9");
contaDoFulano2.Titular = fulano2;

Console.WriteLine(contaDoFulano == contaDoFulano2);

contaDoFulano = contaDoFulano2;
Console.WriteLine(contaDoFulano == contaDoFulano2);

Console.WriteLine(contaDoFulano.exibirDados());

//ContaCorrente contaDoCiclano = new ContaCorrente();
//contaDoCiclano.numeroAgencia = "0900";
//contaDoCiclano.Conta = "3210-7";
//contaDoCiclano.saldo = 250.0;
//contaDoCiclano.Titular.Nome = "Ciclano Tano";
//contaDoCiclano.Titular.CPF = "862.212.860-18";
//contaDoCiclano.Titular.Profissao = "Analista Sr";

//Console.WriteLine(contaDoCiclano.exibirDados());
//System.NullReferenceException: 'Object reference not set to an instance of an object.'
//contaDoCiclano was null.