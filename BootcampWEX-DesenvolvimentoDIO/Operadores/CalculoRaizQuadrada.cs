using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class CalculoRaizQuadrada
    {
        public static void Main()
        {
            double numero = 16.0; // O número do qual queremos calcular a raiz quadrada

            // Calcula a raiz quadrada usando Math.Sqrt
            double raizQuadrada = Math.Sqrt(numero);

            Console.WriteLine($"A raiz quadrada de {numero} é {raizQuadrada}");

            // Aguarda a entrada do usuário para encerrar
            Console.ReadLine();
        }
    }
}
