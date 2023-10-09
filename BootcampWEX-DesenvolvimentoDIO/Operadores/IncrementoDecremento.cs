using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class IncrementoDecremento
    {
        public static void Main()
        {
            int numero = 5;

            // Operador de Incremento (++)

            Console.WriteLine("Valor inicial: " + numero);

            // Incremento pós-fixo: primeiro usa o valor atual, depois incrementa
            int resultadoIncrementoPosFixo = numero++;
            Console.WriteLine("Após incremento pós-fixo: " + resultadoIncrementoPosFixo); // Valor antes do incremento

            // Incremento pré-fixo: primeiro incrementa, depois usa o valor atual
            int resultadoIncrementoPreFixo = ++numero;
            Console.WriteLine("Após incremento pré-fixo: " + resultadoIncrementoPreFixo); // Valor após o incremento

            // Operador de Decremento (--)

            // Decremento pós-fixo: primeiro usa o valor atual, depois decrementa
            int resultadoDecrementoPosFixo = numero--;
            Console.WriteLine("Após decremento pós-fixo: " + resultadoDecrementoPosFixo); // Valor antes do decremento

            // Decremento pré-fixo: primeiro decrementa, depois usa o valor atual
            int resultadoDecrementoPreFixo = --numero;
            Console.WriteLine("Após decremento pré-fixo: " + resultadoDecrementoPreFixo); // Valor após o decremento

            // Aguarda a entrada do usuário para encerrar
            Console.ReadLine();
        }
    }
}
