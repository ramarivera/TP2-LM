using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
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
            //Mientras el usuario desee seguir realizando operaciones se va a repetir el siguiente ciclo.
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el tipo de Cuenta: ");
                Console.WriteLine("1 - Cuenta en Dólares.");
                Console.WriteLine("2 - Cuenta en Pesos.");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("1 - Acreditar Saldo.");
                            Console.WriteLine("2 - Debitar Saldo.");
                            Console.WriteLine("3 - Consultar Saldo.");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    {
                                        Console.Write("Ingrese monto: ");
                                        //Acredita a la cuenta en Dólares el monto ingresado.
                                        iFachada.AcreditarDolares(double.Parse(Console.ReadLine()));
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Ingrese monto: ");
                                        //En el caso de que no haya sido posible la operación debitar se lanza un aviso de que no fue posible 
                                        //realizar la operación.
                                        if (!iFachada.DebitarDolares(double.Parse(Console.ReadLine())))
                                        {
                                            Console.WriteLine("El saldo de su cuenta no es suficiente para realizar esta operación.");
                                        };
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("El saldo de su cuenta en dólares es: {0}", iFachada.SaldoDolares());
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("1 - Acreditar Saldo.");
                            Console.WriteLine("2 - Debitar Saldo.");
                            Console.WriteLine("3 - Consultar Saldo.");
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    {
                                        Console.Write("Ingrese monto: ");
                                        //Acredita el monto ingresado en la cuenta en Pesos.
                                        iFachada.AcreditarPesos(double.Parse(Console.ReadLine()));
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Ingrese monto: ");
                                        //En caso de que no haya sido posible realizar la opeación se lanza un aviso de que no fue posible 
                                        //realizar la operación.
                                        if (!iFachada.DebitarPesos(double.Parse(Console.ReadLine())))
                                        {
                                            Console.WriteLine("El saldo de su cuenta no es suficiente para realizar esta operación.");
                                        };
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("El saldo de su cuenta en pesos es: {0}", iFachada.SaldoPesos());
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    default:
                        break;
                }
                Console.WriteLine("Desea realizar otra opearción? S/N");
            } while (Console.ReadLine() == "S");
        }
    }
}
