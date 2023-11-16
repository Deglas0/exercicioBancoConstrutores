using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioBancoConstrutores
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }





        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 3)
                {
                    _titular = value;
                }
            }
        }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {

            Saldo = saldo;
        }

        public void Saque(double Quantia)
        {
            Saldo -= Quantia-5.00;
            Console.WriteLine("Seu saldo atual:\nR$"+Saldo);
        }
        public void Deposito(double Quantia)
        {
            Saldo += Quantia;
            Console.WriteLine("Seu saldo atual:\nR$"+Saldo);
        }

        public override string ToString()
        {
            return "numero connta bancaria: " + Numero + "\n"
                  + "Titular: " + _titular + "\n"
                  + "Saldo atual: R$" + Saldo.ToString("f2",CultureInfo.InvariantCulture) + "\n";

        }




    }
}
