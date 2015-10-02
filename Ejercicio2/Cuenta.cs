using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Proporciona las propiedades y los métodos necesarios para poder manipular una Cuenta.
    /// </summary>
    /// <remarks>Recuerde utilizar esta clase cuando necesite modificar la información
    /// que hace referencia a una Cuenta.</remarks>
    class Cuenta
    {
        //Atributos
        //Reperesenta el Saldo que contiene la Cuenta.
        private double iSaldo;
        //Representa la moneda que se utiliza en la Cuenta.
        private Moneda iMoneda;

        /// <summary>
        /// Propiedad del Saldo.
        /// </summary>
        public double Saldo
        {
            get { return iSaldo;}
            private set { iSaldo = value; }
        }

        /// <summary>
        /// Constructor de la clase Cuenta.
        /// </summary>
        /// <param name="iMoneda">Moneda que utiliza la cuenta.</param>
        public Cuenta(Moneda iMoneda) : this(0, iMoneda) { }
        /// <summary>
        /// Constructor de la clase Cuenta.
        /// </summary>
        /// <param name="pSaldoInicial">Saldo inicial con el cual se abre una cuenta.</param>
        /// <param name="pMoneda">Moneda que utiliza la cuenta.</param>
        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            iSaldo = pSaldoInicial;
            iMoneda = pMoneda;
        }

        /// <summary>
        /// Acredita a la cuenta un saldo determinado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se va a acreditar.</param>
        public void AcreditarSaldo (double pSaldo)
        {
            Saldo += pSaldo;
        }

        /// <summary>
        /// Debita el saldo de la cuenta en caso de que sea posible.
        /// </summary>
        /// <param name="pSaldo">Saldo que se quiere debitar.</param>
        /// <returns>Devuelve true si fue posible debitar y false para el caso contrario.</returns>
        public Boolean DebitarSaldo (double pSaldo)
        {
            if (Saldo >= pSaldo)
            {
                Saldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
