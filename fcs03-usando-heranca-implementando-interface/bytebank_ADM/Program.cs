using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario fulano = new Funcionario(cpf: "807.018.000-54");
fulano.Nome = "Fulano de Tal";
fulano.salario = 2000.0;

Console.WriteLine(fulano.Nome);
Console.WriteLine(fulano.GetBonificacao().ToString("c"));

Diretor belTrano = new Diretor(cpf: "958.927.410-28");
belTrano.Nome = "Bel Trano";
belTrano.salario = 5000.0;

Console.WriteLine(belTrano.Nome);
Console.WriteLine(belTrano.GetBonificacao().ToString("c"));

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(fulano);
gerenciador.Registrar(belTrano);
Console.WriteLine($"\nTotal em bonificações; {gerenciador.TotalDeBonificacao.ToString("c")}");

Console.WriteLine($"\nTotal de funcionários: {Funcionario.TotalDeFuncionarios}");