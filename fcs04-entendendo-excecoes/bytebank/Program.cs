using bytebank.Contas;
using bytebank.Exceptions;
using bytebank.Utilitario;


#region
//try
//{
//    ContaCorrente conta1 = new ContaCorrente(0, "1213-4");
//    conta1.Sacar(150.0);
//    Console.WriteLine($"Saldo: {conta1.GetSaldo().ToString("c")}");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"Parâmetro com erro: {ex.ParamName}");
//    Console.WriteLine("Ops! Algo deu errado! Não é possível criar uma conta com agência menor ou igual a zero");
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);
//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine("Operação não realizada!");
//    Console.WriteLine(ex.Message);
//}
#endregion

try
{
    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
    leitor.LerProximaLinha();
    leitor.Dispose();
}
catch (IOException ex)
{
    Console.WriteLine("Leitura do arquivo interrompida!");
}