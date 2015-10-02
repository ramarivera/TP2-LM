using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// Proporciona las propiedades y métodos necesarios para la manipulación de un Triángulo.
    /// </summary>
    /// <remarks>Recuerde solo utilizar esta clase cuando quiera modificar la información
    /// de un triángulo.</remarks>
    public class Triangulo
    {
        //Atributos.
        //Cada atributo representa las coordenadas de cada uno de los vértices de un Triángulo.
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        /// <summary>
        /// Propiedad del primer punto.
        /// </summary>
        public Punto Punto1
        {
            get { return this.iPunto1; }
            private set { this.iPunto1 = value; }
        }

        /// <summary>
        /// Propiedad del segundo punto.
        /// </summary>
        public Punto Punto2
        {
            get { return this.iPunto2; }
            private set { this.iPunto2 = value; }
        }

        /// <summary>
        /// Propiedad del tercer punto.
        /// </summary>
        public Punto Punto3
        {
            get { return this.iPunto3; }
            private set { this.iPunto3 = value; }
        }

        /// <summary>
        /// Propiedad del Área de un Triángulo.
        /// </summary>
        public double Area
        {
            get
            {
                //Calcula la distancia desde el Punto 2 hasta el Punto 1
                double lado1 = Punto1.CalcularDistanciaDesde(Punto2);
                double lado2 = Punto2.CalcularDistanciaDesde(Punto3);
                double lado3 = Punto3.CalcularDistanciaDesde(Punto1);
                double semiPerimetro = 0.5 * (lado1 + lado2 + lado3);

                //Devuelve el Área de un Triángulo sin importar la ubicación de los puntos, utilizando la Fórmula de Herón.
                return (Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3)));
            }
        }

        /// <summary>
        /// Propiedad del Perímetro de un Triángulo.
        /// </summary>
        public double Perimetro
        {
            get
            {
                //Calcula la distancia desde Punto 2 hasta el Punto 1.
                double lado1 = Punto1.CalcularDistanciaDesde(Punto2);
                double lado2 = Punto2.CalcularDistanciaDesde(Punto3);
                double lado3 = Punto3.CalcularDistanciaDesde(Punto1);
                return (lado1 + lado2 + lado3);
            }
        }

        /// <summary>
        /// Constructor de la clase Triángulo.
        /// </summary>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            Punto1 = pPunto1;
            Punto2 = pPunto2;
            Punto3 = pPunto3;
        }
    }

}
