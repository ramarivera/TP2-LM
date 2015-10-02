using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{   
    /// <summary>
    /// Controla las entradas y las salidas desde el programa Consola.
    /// </summary>
    public class Interfaz
    {
        static void Main(string[] args)
        {
            //Crea una nueva instancia de Fachada.
            Fachada iFachada = new Fachada();
            Console.WriteLine("Ingrese la opción deseada:");
            Console.WriteLine("1 - Círculo");
            Console.WriteLine("2 - Triángulo");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: //Círculo
                    {
                        //Se solicita cada una de las coordenadas especificadas y se asigna a cada variable el valor 
                        //ingresado por consola transformádolo en doble precisión. 
                        Console.Write("Ingrese la coordenada X del centro: ");
                        double centroX = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del centro: ");
                        double centroY = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el radio del círculo: ");
                        double Radio = double.Parse(Console.ReadLine());

                        //Se asigna a resultado tanto el Área y el Perímetro del círculo.
                        double[] resultado = iFachada.TratarCirculo(centroX, centroY, Radio);
                        
                        Console.WriteLine("El área es: {0}", resultado[0]);
                        Console.WriteLine("El perímetro es: {0}", resultado[1]);
                        break;
                    }
                case 2: //Triángulo
                    {
                        //coordendasPuntos es un vector de 6 posiciones para poner las coordenadas X e Y de cada Punto del Triángulo respectivamente.
                        //Ejemplo: coordenadasPuntos = [X1,Y1,X2,Y2,X3,Y3].
                        double[] coordenadasPuntos = new double[6];
                        //Al el Triángulo tener tres vértices los limites del ciclo se utilizan entre 0 y 4 porque entre ellos 
                        //hay tres números pares. Así quedan representados los tres puntos.
                        //Se utilizan números pares para poder escribir por consola el número del punto, si es el punto 1, el 2 o el 3, 
                        //al cual se le está solicitando la coordenada (utilizando (i/2)+1 se mostrará por consola 1, 2 y 3)
                        //y poder asignarle a la posicion i e i+1 los valores de las coordenadas. 
                        //De esta manera se obtienen 6 posiciones (entre 0 y 5) para el vector coordenadasPuntos y los tres números de los puntos para mostrar por consola.
                        for (int i = 0; i <= 4 ; i+=2)
                        {
                            Console.Write("Ingrese la coordenada X del punto {0}: ", (i/2)+1);
                            coordenadasPuntos[i] = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la coordenada Y del punto {0}: ", (i/2)+1);
                            coordenadasPuntos[i + 1] = double.Parse(Console.ReadLine());
                        }

                        //Se asigna a resultado tanto el Área y el Perímetro del Triángulo.
                        double[] resultado = iFachada.TratarTriangulo(coordenadasPuntos);

                        Console.WriteLine("El área es: {0}", resultado[0]);
                        Console.WriteLine("El perímetro es: {0}", resultado[1]);
                        break;
                    }
                default:
                    Console.WriteLine("La opción ingresada no es correcta.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
