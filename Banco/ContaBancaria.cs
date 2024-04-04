using System.Globalization;

namespace Bank
{
    internal class ContaBancaria
    {


        CultureInfo CI = CultureInfo.InvariantCulture;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double DepositoInicial) : this(numero, titular)
        {
            Deposito(DepositoInicial);
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia; // ou   Saldo -= quantia + 5.0;
            Saldo -= 5.0 ;

        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CI);
        }

    }
}
