using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Propociona las propiedades y los métodos necesarios para la manipulación de cuentas en pesos y en doláres.
    /// </summary>
    /// <remarks>Recuerde utilizar la clase cuando sea necesario modificar la información que hace referecia
    /// a las cuentas en pesos y en dólares.</remarks>
    class Cuentas
    {
        //Atributos
        //Cuenta es Dólares.
        private Cuenta iCuentaEnDolares;
        //Cuenta en Pesos.
        private Cuenta iCuentaEnPesos;

        /// <summary>
        /// Propiedad de la Cuenta en Dólares.
        /// </summary>
        public Cuenta CuentaEnDolares
        {
            get { return iCuentaEnDolares; }
            set { }
        }
        /// <summary>
        /// Propiedad de la Cuenta en Pesos.
        /// </summary>
        public Cuenta CuentaEnPesos
        {
            get { return iCuentaEnPesos; }
        }

        /// <summary>
        /// Constructor de la clase Cuentas.
        /// </summary>
        public Cuentas() 
        {
            //Se crea una nueva intancia Moneda de tipo Dólar.
            Moneda iMonedaDolar = new Moneda("USD", "Dolar", "$");
            iCuentaEnDolares = new Cuenta(iMonedaDolar);
            //Se crea una nueva instancia Moneda de tipo Peso Argentino.
            Moneda iMonedaPesoArgentino = new Moneda("ARS", "Peso Argentino", "$");
            iCuentaEnPesos = new Cuenta(iMonedaPesoArgentino);
        }
       }
}
