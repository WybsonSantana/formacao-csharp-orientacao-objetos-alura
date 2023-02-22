using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            //Console.WriteLine("Criando um Diretor...");
        }

        public override double GetBonificacao()
        {
            return this.salario + base.GetBonificacao();
        }
    }
}
