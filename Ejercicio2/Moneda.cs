using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Proporciona las propiedades y los métodos necesarios para poder manipular una Moneda.
    /// </summary>
    /// <remarks>Recuerde utilizar esta clase cuando sea necesario modificar la información
    /// que refiere a la Moneda.</remarks>
    class Moneda
    {
        //Atributos
        //Representa el id para cada tipo de moneda, mediante su Codigo ISO.
        private string iCodigoISO;
        private string iNombre;
        //Representa el símbolo con el cual se utiliza cada Moneda.
        private string iSimbolo;

        /// <summary>
        /// Propiedad del CodigoISO.
        /// </summary>
        public string CodigoISO 
        {
            get { return iCodigoISO; }
            private set { iCodigoISO = value; }
        }
        /// <summary>
        /// Propiedad del Nombre.
        /// </summary>
        public string Nombre
        {
            get { return iNombre; }
            private set { iNombre = value; }
        }
        /// <summary>
        /// Propiedad del Símbolo.
        /// </summary>
        public string Simbolo
        {
            get { return iSimbolo; }
            private set { iSimbolo = value; }
        }

        /// <summary>
        /// Constructor de la clase Moneda.
        /// </summary>
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            CodigoISO = pCodigoISO;
            Nombre = pNombre;
            Simbolo = pSimbolo;
        }

    }
}
