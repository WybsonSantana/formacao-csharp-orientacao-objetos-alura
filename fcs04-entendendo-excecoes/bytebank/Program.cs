using bytebank.Contas;
using bytebank.Exceptions;

try
{
    ContaCorrente conta1 = new ContaCorrente(278, "1213-4");
    conta1.Sacar(150.0);
    Console.WriteLine($"Saldo: {conta1.GetSaldo().ToString("c")}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}");
    Console.WriteLine("Ops! Algo deu errado! Não é possível criar uma conta com agência menor ou igual a zero");
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação não realizada!");
    Console.WriteLine(ex.Message);
}