using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para el crear, modificar un Motor.
    /// </summary>
    /// <remarks>Recordar que esta clase debe ser utilizada cuando sea necesario modificar la
    /// información accerca del motor.</remarks>
    class Motor
    {
        //Atributos
        private int iLitrosAceite;
        //Representa los Caballos Vapor que tiene el motor de un auto.
        private int iCV;

        /// <summary>
        /// Propiedad Litros Aceite.
        /// </summary>
        public int LitrosAceite
        {
            get { return iLitrosAceite; }
            private set {iLitrosAceite = value;}
        }
        /// <summary>
        /// Propiedad Caballos Vapor.
        /// </summary>
        public int CV
        {
            get { return iCV; }
            private set { iCV = value; }
        }

        /// <summary>
        /// Constructor de la clase Motor.
        /// </summary>
        /// <param name="pCV"></param>
        public Motor (int pCV)
        {
            this.LitrosAceite = 0;
            this.CV = pCV;
        }

        //Métodos
        /// <summary>
        /// Agrega a un Motor una cantidad de litros de aceite determinado. 
        /// </summary>
        /// <param name="pLitrosDeAceite">Cantidad de litros de aceite.</param>
        public void AgregarLitrosAceite (int pLitrosDeAceite)
        {
            this.LitrosAceite += pLitrosDeAceite;
        }

    }
}
