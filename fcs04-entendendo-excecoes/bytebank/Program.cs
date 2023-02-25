using bytebank.Contas;

try
{
    ContaCorrente conta1 = new ContaCorrente(278, "1213-4");
    conta1.Sacar(50.0);
    Console.WriteLine($"Saldo: {conta1.GetSaldo().ToString("c")}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}");
    Console.WriteLine("Ops! Algo deu errado! Não é possível criar uma conta com agência menor ou igual a zero");
    Console.WriteLine(ex.Message);
}