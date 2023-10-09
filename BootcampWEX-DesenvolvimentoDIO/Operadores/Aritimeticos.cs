using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class Aritimeticos
    {
        public static void Main()
        {
            // Exemplos de operadores aritméticos

            int numero1 = 10;
            int numero2 = 5;

            // Soma
            int soma = numero1 + numero2;
            Console.WriteLine("Soma: " + soma);

            // Subtração
            int subtracao = numero1 - numero2;
            Console.WriteLine("Subtração: " + subtracao);

            // Multiplicação
            int multiplicacao = numero1 * numero2;
            Console.WriteLine("Multiplicação: " + multiplicacao);

            // Divisão (cuidado com divisão por zero)
            if (numero2 != 0)
            {
                double divisao = (double)numero1 / numero2;
                Console.WriteLine("Divisão: " + divisao);
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Módulo (resto da divisão)
            int modulo = numero1 % numero2;
            Console.WriteLine("Módulo (Resto da divisão): " + modulo);

            // Incremento e Decremento
            int valor = 5;
            valor++; // Incremento (equivalente a valor = valor + 1)
            Console.WriteLine("Incremento: " + valor);

            valor--; // Decremento (equivalente a valor = valor - 1)
            Console.WriteLine("Decremento: " + valor);

            // Aguarda a entrada do usuário para encerrar
            //Console.ReadLine();
        }
    }
}
