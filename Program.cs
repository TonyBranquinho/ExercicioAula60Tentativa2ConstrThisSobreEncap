using ExercicioAula60Tentativa2ConstrThisSobreEncap;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            
            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titularConta = Console.ReadLine();

            Cliente cli = new Cliente(numeroConta, titularConta);

            Console.Write("Haverá depósito inicial(s / n) ? ");
            char teste = char.Parse(Console.ReadLine());

            Cliente clie = new Cliente();

            clie.DepositoInicial = 0;

            if(teste == 's') {
                Console.Write("Digite o valor de depósito inicial: ");
                clie.DepositoInicial = double.Parse(Console.ReadLine(), CI);
            }      

            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cli.ToString());

        }
    }
}