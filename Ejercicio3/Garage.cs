using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{ 
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para la manipulación de garage.
    /// </summary>
    class Garage
    {
        //Atributos
        private int iNumerosAutosAtendidos;
        //Contiene información acerca del auto que se encuentra en el garage.
        private Auto iAuto;

        /// <summary>
        /// Propiedad del auto.
        /// </summary>
        public Auto Auto
        {
            get { return iAuto; }
            private set { iAuto = value; }
        }
        /// <summary>
        /// Acepta el ingreso de un auto al garage en caso de que sea posible.
        /// </summary>
        /// <param name="pAuto">Auto que se quiere ingresar al garage.</param>
        public void AceptarAuto (Auto pAuto)
        {
            if (this.Auto == null)
            {
                this.Auto = pAuto;
                this.iNumerosAutosAtendidos++;
            }
            else if (pAuto == null)
            {
                this.Auto = pAuto;
            }
        }
        /// <summary>
        /// Acumula los precios de las averias realizadas a un auto.
        /// </summary>
        /// <param name="pPrecioAveria">Precio de la averia realizada.</param>
        /// <param name="pDescripciónAveria">Descripción acerca de la averia que se realizó.</param>
        public void IncorporarAveria (double pPrecioAveria, string pDescripcionAveria)
        {
            this.Auto.SumarAveria(pPrecioAveria);
            if (pDescripcionAveria == "Aceite")
            {
                this.Auto.Motor.AgregarLitrosAceite(10);
            }
        }
    }
}
