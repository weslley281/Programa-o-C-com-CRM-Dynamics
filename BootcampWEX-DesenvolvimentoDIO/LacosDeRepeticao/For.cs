using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.LacosDeRepeticao
{
    internal class For
    {
        public static void Main()
        {
            Console.Write("Digite o numerador da tabuada: ");

            if(double.TryParse(Console.ReadLine(), out double numerador))
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numerador} + {i} = {numerador + i}");
                    
                }

                Console.WriteLine("\n__________________________________________\n");
                
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numerador} - {i} = {numerador - i}");
                }

                Console.WriteLine("\n__________________________________________\n");

                for (double i = 1.0; i <= 10; i++)
                {
                    Console.WriteLine($"{numerador} / {i} = {numerador / i}");
                }

                Console.WriteLine("\n__________________________________________\n");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numerador} X {i} = {numerador * i}");
                }
            }
        }
    }
}
