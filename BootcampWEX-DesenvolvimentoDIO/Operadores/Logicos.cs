using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class Logicos
    {
        public static void Main()
        {
            // Exemplos de operadores lógicos

            // Operador OR (||)
            bool condicao1 = true;
            bool condicao2 = false;

            if (condicao1 || condicao2)
            {
                Console.WriteLine("Pelo menos uma das condições é verdadeira (OR).");
            }
            else
            {
                Console.WriteLine("Nenhuma das condições é verdadeira (OR).");
            }

            // Operador AND (&&)
            if (condicao1 && condicao2)
            {
                Console.WriteLine("Ambas as condições são verdadeiras (AND).");
            }
            else
            {
                Console.WriteLine("Pelo menos uma das condições não é verdadeira (AND).");
            }

            // Operador XOR (^)
            if (condicao1 ^ condicao2)
            {
                Console.WriteLine("Exatamente uma das condições é verdadeira (XOR).");
            }
            else
            {
                Console.WriteLine("Nenhuma das condições é verdadeira ou ambas são verdadeiras (XOR).");
            }

            // Operador NOT (!)
            bool condicao3 = true;
            if (!condicao3)
            {
                Console.WriteLine("A condição é falsa (NOT).");
            }
            else
            {
                Console.WriteLine("A condição é verdadeira (NOT).");
            }

            // Aguarda a entrada do usuário para encerrar
            //Console.ReadLine();
        }
    }
}
