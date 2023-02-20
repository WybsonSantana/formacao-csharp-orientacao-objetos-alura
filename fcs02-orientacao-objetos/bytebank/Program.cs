using bytebank.Contas;
using bytebank.Titular;

Cliente fulano = new Cliente();
fulano.nome = "Fulano de Tal";
fulano.cpf = "164.144.010-48";
fulano.profissao = "Analista Jr";

ContaCorrente contaDoFulano = new ContaCorrente();
contaDoFulano.conta = "1010-9";
contaDoFulano.titular = fulano;

Cliente beltrano = new Cliente();
beltrano.nome = "Bel Trano";
beltrano.cpf = "596.966.280-13";
beltrano.profissao = "Analista PL";

ContaCorrente contaDoBeltrano = new ContaCorrente();
contaDoBeltrano.conta = "2115-5";
contaDoBeltrano.titular = beltrano;

Console.WriteLine($"O saldo da conta de {contaDoFulano.titular.nome} é {contaDoFulano.GetSaldo().ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.titular.nome} é {contaDoBeltrano.GetSaldo().ToString("c")}");

double valorDeposito = 300.0;
Console.WriteLine($"\nDepositando {valorDeposito.ToString("c")} na conta de {contaDoFulano.titular.nome}...");
if (contaDoFulano.Depositar(valorDeposito))
{
    Console.WriteLine("Depósito realizado com sucesso!");
}
else
{
    Console.WriteLine("Depósito não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.titular.nome} é {contaDoFulano.GetSaldo().ToString("c")}");

double valorSaque = 150.00;
Console.WriteLine($"\nSacando {valorSaque.ToString("c")} na conta de {contaDoFulano.titular.nome}...");
if (contaDoFulano.Sacar(valorSaque))
{
    Console.WriteLine("Saque realizado com sucesso!");
}
else
{
    Console.WriteLine("Saque não realizado!");
}
Console.WriteLine($"O saldo da conta de {contaDoFulano.titular.nome} é {contaDoFulano.GetSaldo().ToString("c")}");

double valorTransferencia = 80.0;
string pagador = contaDoBeltrano.titular.nome;
string beneficiario = contaDoFulano.titular.nome;

Console.WriteLine($"\nTransferindo {valorTransferencia.ToString("c")} da conta de {pagador} para a conta de {beneficiario}...");
if (contaDoBeltrano.Transferir(valorTransferencia, contaDoFulano))
{
    Console.WriteLine("Transferência realizada com sucesso!");
}
else
{
    Console.WriteLine("Transferência não realizada!");
}

Console.WriteLine($"\nO saldo da conta de {contaDoFulano.titular.nome} é {contaDoFulano.GetSaldo().ToString("c")}");
Console.WriteLine($"O saldo da conta de {contaDoBeltrano.titular.nome} é {contaDoBeltrano.GetSaldo().ToString("c")}\n");

double valor1 = 300.0;
double valor2 = valor1;
Console.WriteLine(valor1 == valor2);
Console.WriteLine(valor1);
Console.WriteLine(valor2);

Cliente fulano2 = new Cliente();
fulano2.nome = "Fulano de Tal";
fulano2.cpf = "164.144.010-48";
fulano2.profissao = "Analista Jr";

ContaCorrente contaDoFulano2 = new ContaCorrente();
contaDoFulano2.conta = "1010-9";
contaDoFulano2.titular = fulano2;

Console.WriteLine(contaDoFulano == contaDoFulano2);

contaDoFulano = contaDoFulano2;
Console.WriteLine(contaDoFulano == contaDoFulano2);

Console.WriteLine(contaDoFulano.exibirDados());

//ContaCorrente contaDoCiclano = new ContaCorrente();
//contaDoCiclano.numeroAgencia = "0900";
//contaDoCiclano.conta = "3210-7";
//contaDoCiclano.saldo = 250.0;
//contaDoCiclano.titular.nome = "Ciclano Tano";
//contaDoCiclano.titular.cpf = "862.212.860-18";
//contaDoCiclano.titular.profissao = "Analista Sr";

//Console.WriteLine(contaDoCiclano.exibirDados());
//System.NullReferenceException: 'Object reference not set to an instance of an object.'
//contaDoCiclano was null.