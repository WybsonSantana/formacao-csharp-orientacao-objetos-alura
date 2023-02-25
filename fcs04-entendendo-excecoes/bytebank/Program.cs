using bytebank.Contas;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1213-4");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}");
    Console.WriteLine("Ops! Algo deu errado! Não é possível criar uma conta com agência menor ou igual a zero");
    Console.WriteLine(ex.Message);
}

Console.WriteLine(ContaCorrente.TaxaOperacao);