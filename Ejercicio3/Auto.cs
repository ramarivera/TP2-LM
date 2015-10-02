using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para la creación, modificación de un Auto.
    /// </summary>
    /// <remarks>Recordar que esta clase debe ser utiliza cuando sea necesario modificar información
    /// acerca de un Auto.</remarks>
    class Auto
    {
        //Atributos
        //Representa la marca del Auto.
        private string iMarca;
        private string iModelo;
        //Contiene el precio de los arreglos que se le van haciendo a un auto.
        private double iPrecioAverias;
        //Contiene información acerca del motor del Auto.
        private Motor iMotor;

        /// <summary>
        /// Propiedad de la Marca.
        /// </summary>
        public string Marca
        {
            get { return iMarca; }
            private set { iMarca = value; }
        }
        /// <summary>
        /// Propiedad del Modelo.
        /// </summary>
        public string Modelo
        {
            get { return iModelo; }
            private set { iModelo = value; }
        }
        /// <summary>
        /// Propiedad del Precio de las Averias.
        /// </summary>
        public double PrecioAverias
        {
            get { return iPrecioAverias; }
            private set { iPrecioAverias = value; }
        }
        /// <summary>
        /// Propiedad del Motor.
        /// </summary>
        public Motor Motor
        {
            get { return iMotor; }
            private set { iMotor = value; }
        }

        /// <summary>
        /// Constructor de la clase Auto.
        /// </summary>
        /// <param name="pMarca">Nombre de la marca del auto.</param>
        /// <param name="pCV">Caballos Vapor del motor del auto.</param>
        /// <param name="pModelo">Nombre del modelo del auto.</param>
        public Auto (string pMarca, string pModelo, int pCV)
        {
            this.Marca = pMarca;
            this.Modelo = pModelo;
            Motor iMotorNuevo = new Motor(pCV);
            this.Motor = iMotorNuevo;
        }

        /// <summary>
        /// Acumula los precio de las averias realizadas a un auto.
        /// </summary>
        /// <param name="pPrecioAveria">Precio de la Averia.</param>
        public void SumarAveria (double pPrecioAveria)
        {
            this.PrecioAverias += pPrecioAveria;
        }
    }
}
