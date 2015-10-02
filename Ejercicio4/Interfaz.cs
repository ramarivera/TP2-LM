using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Controla las entradas y las salidas desde el programa Consola.
    /// </summary>
    class Interfaz
    {
        static void Main(string[] args)
        {
            Fachada iFachada = new Fachada();
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione la operacion que desea realizar: ");
                Console.WriteLine("1 - Alta de Libro.");
                Console.WriteLine("2 - Consultar Libro.");
                Console.WriteLine("3 - Consultar Libros en Biblioteca.");
                Console.WriteLine("4 - Baja de Libro.");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            //En el caso de que la Biblioteca esté llena no se podrán dar de altas más libros.
                            if (iFachada.BibliotecaLlena())
                            {
                                Console.WriteLine("No se pueden agregar Libros a la Biblioteca.");
                            }
                            else
                            {
                                //Solicita mediante consola los datos del libro para poder realizar el alta.
                                Console.Write("Codigo ISBN: ");
                                long ISBN = long.Parse(Console.ReadLine());
                                Console.Write("Nombre del Libro: ");
                                string Nombre = Console.ReadLine();
                                Console.Write("Editorial: ");
                                string Editorial = Console.ReadLine();
                                Console.Write("Autor: ");
                                string Autor = Console.ReadLine();
                                Console.Write("Año de edición: ");
                                int anio = int.Parse(Console.ReadLine());
                                iFachada.AltaDeLibro(ISBN, Nombre, Editorial, Autor, anio);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese ISBN del libro que desea consultar: ");
                            long ISBN = long.Parse(Console.ReadLine());
                            //Consulta si el ISBN ingresado por consola existe dentro de la biblioteca. 
                            if (iFachada.LibroEnBiblioteca(ISBN))
                            {
                                Console.Clear();
                                //Le asocia a infLibro la información del libro con el correpondiente código ISBN.
                                Libro infLibro = iFachada.ObtenerInformaciónLibro(ISBN);
                                Console.WriteLine("Código ISBN: {0}", infLibro.ISBN);
                                Console.WriteLine("Nombre: {0}", infLibro.Nombre);
                                Console.WriteLine("Editorial: {0}", infLibro.Editorial);
                                Console.WriteLine("Autor: {0}", infLibro.Autor);
                                Console.WriteLine("Año de edición: {0}", infLibro.Anio);
                            }
                            else
                            {
                                Console.WriteLine("El libro que consultó no se encuentra en la Bilioteca.");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Los libros actualmente en Biblioteca son: ");
                            Libro[] librosBiblioteca = iFachada.TodosLibrosEnBiblioteca();
                            for (int i = 0; i < librosBiblioteca.Length; i++)
                            {
                                if (librosBiblioteca[i] != null)
                                {
                                    Console.WriteLine("El libro con código {0} se encuentra en Bilbioteca.", librosBiblioteca[i].ISBN);
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ingrese código ISBN: ");
                            long ISBN = long.Parse(Console.ReadLine());
                            //Si el libro que se quiere dar de baja no se encuentra en la biblioteca se lanza un aviso indicando
                            //que no se encuentra en la biblioteca.
                            if (iFachada.LibroEnBiblioteca(ISBN))
                            {
                                iFachada.BajaDeLibro(ISBN);
                                Console.WriteLine("Se ha dado de baja el libro.");
                            }
                            else
                            {
                                Console.WriteLine("El libro que desea dar de baja no se encuentra en Bilbioteca.");
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

