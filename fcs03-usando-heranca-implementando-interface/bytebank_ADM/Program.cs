using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario fulano = new Funcionario();
fulano.Nome = "Fulano de Tal";
fulano.Cpf = "807.018.000-54";
fulano.salario = 2000.0;

Console.WriteLine(fulano.Nome);
Console.WriteLine(fulano.GetBonificacao().ToString("c"));

Diretor belTrano = new Diretor();
belTrano.Nome = "Bel Trano";
belTrano.Cpf = "958.927.410-28";
belTrano.salario = 5000.0;

Console.WriteLine(belTrano.Nome);
Console.WriteLine(belTrano.GetBonificacao().ToString("c"));

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(fulano);
gerenciador.Registrar(belTrano);
Console.WriteLine($"\nTotal em bonificações; {gerenciador.TotalDeBonificacao.ToString("c")}");