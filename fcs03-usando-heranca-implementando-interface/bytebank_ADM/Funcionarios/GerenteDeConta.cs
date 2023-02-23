using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public string Senha { get; set; }

        public GerenteDeConta(string cpf) : base(cpf, 4000.0)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
