using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class Potencia
    {
        public static void main()
        {
            double baseCalculo = 2.0;
            int expoente = 3;

            double resultado = Math.Pow(baseCalculo, expoente);

            Console.WriteLine($"{baseCalculo} elevado a {expoente} é igua à {resultado}");
        }
    }
}
