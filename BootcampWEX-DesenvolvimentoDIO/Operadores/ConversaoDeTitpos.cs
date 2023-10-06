using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.OperadoresDeAtribuiacao
{
    internal class ConversaoDeTitpos
    {
        public static void main()
        {
            // Conversão implícita
            int numeroInteiro = 42;
            double numeroDecimal = numeroInteiro; // Conversão implícita de int para double

            Console.WriteLine("Conversão implícita de int para double: " + numeroDecimal);

            // Conversão explícita
            double numeroDecimal2 = 3.14;
            int numeroInteiro2 = (int)numeroDecimal2; // Conversão explícita de double para int

            Console.WriteLine("Conversão explícita de double para int: " + numeroInteiro2);

            // Conversão de string para número
            string textoNumero = "123";
            int numeroConvertido = int.Parse(textoNumero); // Convertendo uma string em um int

            Console.WriteLine("Conversão de string para int: " + numeroConvertido);

            // Conversão de número para string
            int numero = 456;
            string numeroComoString = numero.ToString(); // Convertendo um int em uma string

            Console.WriteLine("Conversão de int para string: " + numeroComoString);

            // Aguardar a entrada do usuário para encerrar
            //Console.ReadLine();
        }
    }
}
