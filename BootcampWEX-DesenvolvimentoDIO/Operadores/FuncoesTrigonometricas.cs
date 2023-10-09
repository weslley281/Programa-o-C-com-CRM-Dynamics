using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class FuncoesTrigonometricas
    {
        public static void Main()
        {
            double anguloEmRadiano = Math.PI / 4;

            double seno = Math.Sin(anguloEmRadiano);
            Console.WriteLine($"Seno do angulo: {seno}");

            double cosseno = Math.Cos(anguloEmRadiano);
            Console.WriteLine($"Cosseno do anguloEmRadiano é {cosseno}");

            double tangente = Math.Tan(anguloEmRadiano);
            Console.WriteLine($"Tangente do ângulo: {tangente}");
        }
    }
}
