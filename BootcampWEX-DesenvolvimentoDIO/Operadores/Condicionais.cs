using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class Condicionais
    {
        public static void main()
        {
            Console.Write("Bem-vindo! Por favor, insira um número inteiro: ");

            // Lê a entrada do usuário e tenta converter para um número inteiro
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Verifica se o número é positivo, negativo ou zero
                if (numero > 0)
                {
                    Console.WriteLine("Você inseriu um número positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Você inseriu um número negativo.");
                }
                else
                {
                    Console.WriteLine("Você inseriu zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
            }

            // Aguarda a entrada do usuário para encerrar
            Console.ReadLine();
        }
    }
}
