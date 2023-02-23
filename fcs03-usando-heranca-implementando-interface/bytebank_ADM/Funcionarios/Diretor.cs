using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }

        public Diretor(string cpf) : base(cpf, 5000.0)
        {
            //Console.WriteLine("Criando um Diretor...");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario *= 0.5;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
