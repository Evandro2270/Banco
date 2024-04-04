using Bank;

using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;


                ContaBancaria conta;

                Console.Write("Entre com numero da Conta: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta: ");
                string titular = Console.ReadLine();
                Console.Write("Havera deposito inicial (s/n): ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Entre o valor de deposito inicial: ");
                    double depositoIicial = double.Parse(Console.ReadLine(), CI);
                    conta = new ContaBancaria(numero, titular, depositoIicial);
                }
                else
                {
                    conta = new ContaBancaria(numero, titular);
                }
                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre um valor para deposito: ");
                double quantia = double.Parse(Console.ReadLine(), CI);
                conta.Deposito(quantia);
                Console.WriteLine("Dados da conta atualizado: ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                quantia = double.Parse(Console.ReadLine(), CI);
                conta.Saque(quantia);
                Console.WriteLine("Dados da conta atualizado: ");
                Console.WriteLine(conta);

            }
        }
    }
}