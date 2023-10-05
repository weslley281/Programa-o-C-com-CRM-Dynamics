using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.TiposDeVariaveis
{
    internal class Tipos
    {
        public static void main()
        {
            // Tipos de variáveis

            // Variáveis numéricas
            int numeroInteiro = 10;
            double numeroDecimal = 3.14;
            float numeroFlutuante = 2.5f;

            // Variável de texto
            string texto = "Olá, mundo!";

            // Variável booleana
            bool verdadeiroOuFalso = true;

            // Variáveis de data e hora
            DateTime dataAtual = DateTime.Now;

            // Exibindo os valores
            Console.WriteLine("Variável de inteiro: " + numeroInteiro);
            Console.WriteLine("Variável decimal: " + numeroDecimal);
            Console.WriteLine("Variável flutuante: " + numeroFlutuante);
            Console.WriteLine("Variável de texto: " + texto);
            Console.WriteLine("Variável booleana: " + verdadeiroOuFalso);
            Console.WriteLine("Variável de data e hora: " + dataAtual);

            // Aguardar a entrada do usuário para encerrar
            //Console.ReadLine();
        }
    }
}
