using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.LacosDeRepeticao
{
    internal class DoWhile
    {
        public static void Main()
        {
            Console.Write("Digite o numerador da tabuada: ");

            if (int.TryParse(Console.ReadLine(), out int numerador))
            {
                int contador = 1;
                do
                {
                    Console.WriteLine($"{numerador} X {contador} = {numerador * contador}");
                    contador++;
                } while (contador <= 10);
            }
        }
    }
}
