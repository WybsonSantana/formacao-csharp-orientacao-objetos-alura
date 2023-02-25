using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Utilitario
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            this.Arquivo = arquivo;

            // throw new FileNotFoundException();

            Console.WriteLine($"Abrindo arquivo: {arquivo}");
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo a linha do arquivo...");

            //throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando o arquivo...");
        }
    }
}
