using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para manipular un Punto.
    /// </summary>
    /// <remarks>Recordar utilizar esta clase solo cuando sea necesario modificar la información de un Punto.</remarks>
    public class Punto
    {
        //Atributos.
        //Representa la coordena X, es decir la abscisa, de un punto.
        private double iX;
        //Representa la coordena Y, es decir la ordenada, de un punto.
        private double iY;

        /// <summary>
        /// Propiedad de la coordenada X.
        /// </summary>
        public double X
        {
            get { return this.iX; }
            private set { this.iX = value; }
        }
        
        /// <summary>
        /// Propiedad de la coordenada Y.
        /// </summary>
        public double Y
        {
            get { return this.iY; }
            private set { this.iY = value; }
        }

        //metodos
        /// <summary>
        /// Calcula la distancia entre dos puntos, utilizando norma Euclidiana.
        /// </summary>
        /// <param name="pPunto">Indica las coordenadas (X,Y) de un punto desde el 
        /// cual se quiere calcular la distacia.</param>
        /// <returns>Devuelve la distancia entre dos puntos.</returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return (Math.Sqrt(Math.Pow(this.X - pPunto.X, 2) + Math.Pow(this.Y - pPunto.Y, 2))); 
        }

        /// <summary>
        /// Constructor de la clase Punto.
        /// </summary>
        public Punto(double pX, double pY)
        {
            this.X = pX;
            this.Y = pY;
        }
    }

}
