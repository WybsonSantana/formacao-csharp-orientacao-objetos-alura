using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double salario { get; set; }

        public Funcionario()
        {
            Console.WriteLine("Criando um Funcionário...");
            TotalDeFuncionarios++;
        }
        public virtual double GetBonificacao()
        {
            return this.salario * 0.1;
        }
    }
}
