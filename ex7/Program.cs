using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tipo de voto");
            Console.WriteLine("V - Validos");
            Console.WriteLine("B - Brancos");
            Console.WriteLine("N - Nulos");
            String tipoVoto;
            tipoVoto = Console.ReadLine();
            int contValido;

            switch (tipoVoto)
            {
                case "V":
                    
                    contValido = contValido+1; 

                    break;
                case "B":

                    break;
                case "N":

                    break;

            }
        }
    }
}
