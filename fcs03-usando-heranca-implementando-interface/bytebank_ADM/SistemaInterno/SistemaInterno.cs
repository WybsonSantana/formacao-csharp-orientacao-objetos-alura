using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Diretor diretor, string senha)
        {
            bool usuarioAutenticado = diretor.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja bem-vindo(a) ao ByteBank!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida!");
                return false;
            }
        }

        public bool Logar(GerenteDeConta gerente, string senha)
        {
            bool usuarioAutenticado = gerente.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja bem-vindo(a) ao ByteBank!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida!");
                return false;
            }
        }
    }
}
