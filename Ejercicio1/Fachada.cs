using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// Homogeiniza el acceso a las diferentes figuras, Triángulo y Círculo.
    /// </summary>
    public class Fachada
    {
        /// <summary>
        /// Cacula el área y el perímetro para un Círculo.
        /// </summary>
        /// <param name="pX">Coordenada X o abscisa del centro del Círculo.</param>
        /// <param name="pY">Coordenada Y o ordenada del centro del Círulo.</param>
        /// <param name="pRadio">Indica el radio del Círuclo.</param>
        /// <returns>Devuelve un vector en donde su primera posición es el Área y la segunda
        /// posición es el Perímetro.</returns>
        public double[] TratarCirculo(double pX, double pY, double pRadio)
        {
            double[] resultado = new double[2];
            //Crea una nueva instancia de Punto.
            Punto iCentro = new Punto(pX, pY);
            double iRadio = pRadio;
            //Crea una nueva instancia de Círculo.
            Circulo iCirculo = new Circulo(iCentro, iRadio);
            resultado[0] = iCirculo.Area;
            resultado[1] = iCirculo.Perimetro;
            return resultado;
        }
        
        /// <summary>
        /// Calcula el Área y el Perímetro de un Triángulo.
        /// </summary>
        /// <param name="pCoordenadasTriangulo">Contiene las coordenadas X e Y de cada uno de los vértices del Triángulo.</param>
        /// <example>Si los puntos son (1,2) (0,0) (1,10) entonces pCoordenadasTriangulo = [1,2,0,0,1,10].</example>
        /// <returns>Devuelve un vector en donde su primera posición contiene al Área de Triángulo
        /// y la segunda posición contiene al Perímetro del Triángulo.</returns>
        public double[] TratarTriangulo (double[] pCoordenadasTriangulo)
        {
            double[] resultado = new double[2];
            //Crea nuevas intancias de Punto pasando como parámetro de entrada las coordenadas X e Y 
            //para cada vértice del Triángulo.
            Punto iPunto1 = new Punto(pCoordenadasTriangulo[0], pCoordenadasTriangulo[1]);
            Punto iPunto2 = new Punto(pCoordenadasTriangulo[2], pCoordenadasTriangulo[3]);
            Punto iPunto3 = new Punto(pCoordenadasTriangulo[4], pCoordenadasTriangulo[6]);
            //Crea una nueva intancia de Triángulo.
            Triangulo iTriangulo = new Triangulo(iPunto1,iPunto2,iPunto3);
            resultado[0] = iTriangulo.Area;
            resultado[1] = iTriangulo.Perimetro;
            return resultado;

        }
    }
}
