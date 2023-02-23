﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;


#region
//Funcionario fulano = new Funcionario(cpf: "807.018.000-54", salario: 2000.0);
//fulano.Nome = "Fulano de Tal";

//Diretor belTrano = new Diretor(cpf: "958.927.410-28");
//belTrano.Nome = "Bel Trano";

//Console.WriteLine($"Nome: {fulano.Nome}");
//Console.WriteLine($"Salário: {fulano.Salario.ToString("c")}");
//Console.WriteLine($"Bonificação: {fulano.GetBonificacao().ToString("c")}");

//fulano.AumentarSalario();
//Console.WriteLine($"Salário após aumento: {fulano.Salario.ToString("c")}");
//Console.WriteLine($"Bonificação: {fulano.GetBonificacao().ToString("c")}\n");

//Console.WriteLine($"Nome: {belTrano.Nome}");
//Console.WriteLine($"Salário: {belTrano.Salario.ToString("c")}");
//Console.WriteLine($"Bonificação: {belTrano.GetBonificacao().ToString("c")}");

//belTrano.AumentarSalario();
//Console.WriteLine($"Salário após aumento: {belTrano.Salario.ToString("c")}");
//Console.WriteLine($"Bonificação: {belTrano.GetBonificacao().ToString("c")}\n");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(fulano);
//gerenciador.Registrar(belTrano);
//Console.WriteLine($"Total em bonificações; {gerenciador.TotalDeBonificacao.ToString("c")}");

//Console.WriteLine($"\nTotal de funcionários: {Funcionario.TotalDeFuncionarios}");
#endregion
//CalcularBonificacao();

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Auxiliar adriane = new Auxiliar(cpf: "501.210.241-56");
    adriane.Nome = "Adriane Martins";
    gerenciador.Registrar(adriane);

    Designer aline = new Designer(cpf: "212.301.363-20");
    aline.Nome = "Aline Melo";
    gerenciador.Registrar(aline);

    GerenteDeConta ludimila = new GerenteDeConta(cpf: "512.423.654-51");
    ludimila.Nome = "Ludimila Fernandes";
    gerenciador.Registrar(ludimila);

    Diretor marcia = new Diretor(cpf: "111.344.471-16");
    marcia.Nome = "Márcia Gomes";
    gerenciador.Registrar(marcia);

    Console.WriteLine($"Total em bonificações: {gerenciador.TotalDeBonificacao.ToString("c")}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor patricia = new Diretor(cpf: "512.315.406-56");
    patricia.Nome = "Patrícia Reis";
    patricia.Senha = "1234";
    sistema.Logar(patricia, "1234");

    GerenteDeConta juliana = new GerenteDeConta(cpf: "001.404.451-02");
    juliana.Nome = "Juliana Freitas";
    juliana.Senha = "5678";
    sistema.Logar(juliana, "5678");

    Auxiliar fernanda = new Auxiliar(cpf: "610.045.273-65");
    fernanda.Nome = "Fernanda Mendes";
    fernanda.Senha = "2345";
    sistema.Logar(fernanda, "2345");

    Designer marcelle = new Designer(cpf: "021.223.246-00");
    marcelle.Nome = "Marcelle Freitas";
    marcelle.Senha = "3456";
    sistema.Logar(marcelle, "3456");
}