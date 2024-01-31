using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula60Tentativa2ConstrThisSobreEncap {
    internal class Cliente {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public int NumeroConta;
        public string TitularConta;
        public double DepositoInicial;
        public double Saldo;

        public Cliente() { 
        }

        public Cliente(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public double Deposito(double deposito) {
            return deposito + Saldo + DepositoInicial;
        }


        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: $ "
                + Saldo.ToString("F2", CI);
        }

    }
}
