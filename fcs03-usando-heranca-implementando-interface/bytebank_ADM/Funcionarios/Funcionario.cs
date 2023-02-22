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
        public string Cpf { get; private set; }
        public double salario { get; set; }

        public Funcionario(string cpf)
        {
            //Console.WriteLine("Criando um Funcionário...");
            this.Cpf = cpf;
            TotalDeFuncionarios++;
        }
        public virtual double GetBonificacao()
        {
            return this.salario * 0.1;
        }
    }
}
