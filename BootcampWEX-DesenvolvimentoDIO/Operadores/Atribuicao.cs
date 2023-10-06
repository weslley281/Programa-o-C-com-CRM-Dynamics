using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.OperadoresDeAtribuiacao
{
    internal class Atribuicao
    {
        public static void main()
        {
            // Operadores de Atribuição
            int a = 10;
            int b = 5;

            Console.WriteLine("Valor inicial de a: " + a);
            Console.WriteLine("Valor inicial de b: " + b);

            // Operador de atribuição simples
            a = b;
            Console.WriteLine("Após a = b, valor de a: " + a);

            // Operadores de atribuição combinados
            a += 5; // Equivalente a a = a + 5
            b -= 3; // Equivalente a b = b - 3

            Console.WriteLine("Após a += 5, valor de a: " + a);
            Console.WriteLine("Após b -= 3, valor de b: " + b);

            // Operador de atribuição de multiplicação
            a *= 2; // Equivalente a a = a * 2

            Console.WriteLine("Após a *= 2, valor de a: " + a);

            // Operador de atribuição de divisão
            b /= 2; // Equivalente a b = b / 2

            Console.WriteLine("Após b /= 2, valor de b: " + b);

            // Operador de atribuição de resto
            a %= 3; // Equivalente a a = a % 3

            Console.WriteLine("Após a %= 3, valor de a: " + a);

            // Aguardar a entrada do usuário para encerrar
            //Console.ReadLine();
        }
    }
}
