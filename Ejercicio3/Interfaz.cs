using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Controla las entradas y las salidas desde el programa Consola.
    /// </summary>
    class Interfaz
    {
        static void Main(string[] args)
        {
            //Crea una nueva instancia de Fachada.
            Fachada iFachada = new Fachada();
            //Mientras el usuario desee seguir realizando opeación se va a repetir el siguiente ciclo.
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione la operación que desea realizar: ");
                Console.WriteLine("1 - Ingresar auto.");
                Console.WriteLine("2 - Ingresar averia.");
                Console.WriteLine("3 - Retirar auto");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            //Verifica si el garage esta ocupado por otro auto. Si lo está lanza un aviso indicando que está ocupado, 
                            //en caso contrario ingresa el auto al garage.
                            if (! iFachada.GarageDisponible())
                            {
                                Console.WriteLine("El garage esta ocupado reparando otro auto.");
                            }     
                            else
                            {
                                //Se obtiene mediante console la marca, el modelo y los caballos vapor del auto que va a ingresar en el garage.
                                Console.Write("Marca del auto: ");
                                string marca = Console.ReadLine();
                                Console.Write("Modelo del auto: ");
                                string modelo = Console.ReadLine();
                                Console.Write("Caballos vapor del motor: ");
                                int CV = int.Parse(Console.ReadLine());
                                iFachada.IngresarAuto(marca, modelo, CV);
                            }
                            break;
                        }
                    case 2:
                        {
                            //En el caso de que en el garage no haya ningún auto no se puede agregar ninguna averia.
                            if (iFachada.GarageDisponible())
                            {
                                 Console.WriteLine("No se puede realizar esta operación debido a que no hay ningún auto en el garage."); 
                            }
                            else
                            {
                                //Se obtiene mediante consola la información correspondiente a la averia que se va a realizar.
                                Console.Write("Descricpción de la averia a realizar: ");
                                string Descripcion = Console.ReadLine();
                                Console.Write("Precio de la averia: ");
                                double precioA = double.Parse(Console.ReadLine());
                                iFachada.IngresarAveria(Descripcion, precioA);
                            }                            
                            break;
                        }
                    case 3:
                        {
                            //En el caso de que en el garage no haya ningún auto, no se puede retirar el mismo.
                            if (iFachada.GarageDisponible())
                            {
                                Console.WriteLine("No se puede realizar esta operación debido a que no hay ningún auto en el garage.");                                
                            }
                            else
                            {
                                //Auto contiene toda la información acerca del auto que se está retirando del garage.
                                string[] Auto = iFachada.RecuperarInformacionAuto();
                                //Se muestra por consola cada una de las posiciones de Auto, la cuales contienen diferentes
                                //atributos del auto.
                                Console.WriteLine("Marca del auto: {0}", Auto[0]);
                                Console.WriteLine("Modelo del auto: {0}", Auto[1]);
                                Console.WriteLine("Caballos Vapor del motor: {0}", Auto[2]);
                                Console.WriteLine("Monto de las averias realizadas: {0}", Auto[3]);
                                Console.WriteLine("Litros de Aceite del motor: {0}", Auto[4]);
                                iFachada.RetirarAuto();
                            }
                            
                            break;
                        }
                    default:
                        break;
                }
                Console.Write("Desea realizar otra operación? S/N : ");
            } while (Console.ReadLine() == "S");
        }
    }
}
