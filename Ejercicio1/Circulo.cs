using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// Proporciona todas las propiedades y métodos necesarios para la manipulación de un cículo.
    /// </summary>
    /// <remarks>Recordar utilizar esta clase solo cuando sea necesario modificar la información de un Circulo.</remarks>
    public class Circulo
    {
        //Atributos.
        //Reperesenta el Radio de una Circunferencia.
        private double iRadio;
        //Representa el Centro de una Circunferencia. 
        private Punto iCentro;

        /// <summary>
        /// Porpiedad del Radio.
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
            private set { this.iRadio = value; }
        }

        /// <summary>
        /// Propiedad del Centro.
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
            private set { this.iCentro = value; }
        }

        /// <summary>
        /// Propiedad del Área.
        /// </summary>
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.Radio, 2)); }
        }

        /// <summary>
        /// Propiedad del Perímetro.
        /// </summary>
        public double Perimetro
        {
            get { return (2 * Math.PI * this.Radio); }
        }

        /// <summary>
        /// Constructor de la clase Círculo.
        /// </summary>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.Radio = pRadio;
            this.Centro = pCentro;
        }
        public Circulo(double pX, double pY, double pRadio)
        {
            this.Radio = pRadio;
            this.Centro = new Punto(pX, pY);
        }
    }

}
