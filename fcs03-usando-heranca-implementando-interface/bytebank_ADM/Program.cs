using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario fulano = new Funcionario(cpf: "807.018.000-54", salario: 2000.0);
fulano.Nome = "Fulano de Tal";

Diretor belTrano = new Diretor(cpf: "958.927.410-28", salario: 5000.0);
belTrano.Nome = "Bel Trano";

Console.WriteLine($"Nome: {fulano.Nome}");
Console.WriteLine($"Salário: {fulano.Salario.ToString("c")}");
Console.WriteLine($"Bonificação: {fulano.GetBonificacao().ToString("c")}");

fulano.AumentarSalario();
Console.WriteLine($"Salário após aumento: {fulano.Salario.ToString("c")}");
Console.WriteLine($"Bonificação: {fulano.GetBonificacao().ToString("c")}\n");

Console.WriteLine($"Nome: {belTrano.Nome}");
Console.WriteLine($"Salário: {belTrano.Salario.ToString("c")}");
Console.WriteLine($"Bonificação: {belTrano.GetBonificacao().ToString("c")}");

belTrano.AumentarSalario();
Console.WriteLine($"Salário após aumento: {belTrano.Salario.ToString("c")}");
Console.WriteLine($"Bonificação: {belTrano.GetBonificacao().ToString("c")}\n");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(fulano);
gerenciador.Registrar(belTrano);
Console.WriteLine($"Total em bonificações; {gerenciador.TotalDeBonificacao.ToString("c")}");

Console.WriteLine($"\nTotal de funcionários: {Funcionario.TotalDeFuncionarios}");