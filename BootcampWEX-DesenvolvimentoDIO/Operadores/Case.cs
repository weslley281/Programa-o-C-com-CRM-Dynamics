using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampWEX_DesenvolvimentoDIO.Operadores
{
    internal class Case
    {
        public static void main()
        {
            Console.WriteLine("1 - Maçã");
            Console.WriteLine("2 - Banana");
            Console.WriteLine("3 - Laranja");
            Console.WriteLine("4 - Pêra");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Você escolheu Maçã.");
                    break;
                case "2":
                    Console.WriteLine("Você escolheu Banana.");
                    break;
                case "3":
                    Console.WriteLine("Você escolheu Laranja.");
                    break;
                case "4":
                    Console.WriteLine("Você escolheu Pêra.");
                    break;
                case "5":
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }

            // Aguarda a entrada do usuário para encerrar
            Console.ReadLine();
        }
    }
}
