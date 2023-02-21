using bytebank_ADM.Funcionarios;

Funcionario fulano = new Funcionario();
fulano.Nome = "Fulano de Tal";
fulano.Cpf = "807.018.000-54";
fulano.salario = 2000.0;

Console.WriteLine(fulano.Nome);
Console.WriteLine(fulano.GetBonificacao().ToString("c"));