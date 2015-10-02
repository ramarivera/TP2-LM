using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Homogeiniza el acceso a las diferentes cuentas.
    /// </summary>
    class Fachada
    {
        //Crea una nueva instancia de Cuentas.
        private Cuentas iCuentas = new Cuentas();
 
        /// <summary>
        /// Acredita a la cuenta en pesos un saldo determinado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea acreditar.</param>
        public void AcreditarPesos (double pSaldo)
        {
            iCuentas.CuentaEnPesos.AcreditarSaldo(pSaldo);
        }
        /// <summary>
        /// Acredita a la cuenta en dólares un saldo determinado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea acreditar.</param>
        public void AcreditarDolares (double pSaldo)
        {
            iCuentas.CuentaEnDolares.AcreditarSaldo(pSaldo);
        }
        /// <summary>
        /// Debita un saldo determinado en la Cuenta en pesos, siempre y cuando sea posible.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea debitar.</param>
        /// <returns>Devuelve true si fue posible debitar y false para el caso contrario.</returns>
        public Boolean DebitarPesos (double pSaldo)
        {
            return iCuentas.CuentaEnPesos.DebitarSaldo(pSaldo);
        }
        /// <summary>
        /// Determina si es posible debitar en la Cuenta en dólares.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea debitar.</param>
        /// <returns>Devuelve true en caso que se pueda debitar y false para el caso contrario.</returns>
        public Boolean DebitarDolares (double pSaldo)
        {
            return iCuentas.CuentaEnDolares.DebitarSaldo(pSaldo);
        }
        /// <summary>
        /// Consulta el saldo que tiene la cuenta en dólares.
        /// </summary>
        /// <returns>Devuelve el saldo que contiene.</returns>
        public double SaldoDolares ()
        {
            return iCuentas.CuentaEnDolares.Saldo;
        }
        /// <summary>
        /// Consulta el saldo que tiene la cuenta en pesos.
        /// </summary>
        /// <returns>Devuelve el saldo que contiene.</returns>
        public double SaldoPesos ()
        {
            return iCuentas.CuentaEnPesos.Saldo;
        }

    }
}
