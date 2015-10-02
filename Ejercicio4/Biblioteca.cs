using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Proporciona las priopedades y métodos para la manipulación de una Biblioteca.
    /// </summary>
    class Biblioteca
    {
        //Atributos
        //Libros contiene la cantidad máxima de libros que puede tener la Biblioteca.
        private Libro[] iLibros;
        //Representa la cantidad de libros que tiene la Biblioteca en el momento.
        private int iCantidadDeLibrosActuales;
        
        /// <summary>
        /// Propiedad de los libros que tiene la Biblioteca.
        /// </summary>
        public Libro[] Libros
        {
            get { return iLibros; }
            set { iLibros = value; }
        }

        /// <summary>
        /// Propiedad de cantidad de libros actuales en Biblioteca.
        /// </summary>
        public int CantidadDeLibtosActuales
        {
            get { return iCantidadDeLibrosActuales; }
            private set { iCantidadDeLibrosActuales = value; }
        }

        /// <summary>
        /// Constructor de la clase Biblioteca.
        /// </summary>
        public Biblioteca()
        {
            this.Libros = new Libro[5];
            this.CantidadDeLibtosActuales = 0;
        }

        /// <summary>
        /// Verifica si la Bilbioteca llego a su máximo de libros.
        /// </summary>
        /// <returns>Devuelve true en caso de que la Biblioteca este llena.</returns>
        public Boolean BibliotecaLlena ()
        {
            if (this.CantidadDeLibtosActuales == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Encuentra la primera posicion libre de la Biblioteca para poder colocar un nuevo libro.
        /// </summary>
        /// <param name="pLibro">Libros que se encuentran actualmente en la Biblioteca.</param>
        /// <returns>Devuelve la posicion para colocar el libro en la Biblioteca.</returns>
        public int PosiconLibroDisponible(Libro[] pLibro)
        {
            int posicion = 0;
            //Se controla que no se supere la cantidad de libros que hay en biblioteca y la posición no este disponible.
            while (posicion <= 4 && pLibro[posicion] != null)
            {
                posicion++;
            }
            return posicion;
        }

        /// <summary>
        /// Agrega un nuevo libro a la Biblioteca.
        /// </summary>
        /// <param name="pLibro">Libro que se quiere dar de alta.</param>
        /// <returns>Devuelve true si se pudo dar de alta el libro a la Biblioteca.</returns>
        public Boolean AltaDeLibroEnBiblioteca (Libro pLibro)
        {
            if (! BibliotecaLlena())
            {
                //Obtiene una posicion libre para poder colocar el libro.
                int posicion = PosiconLibroDisponible(this.Libros);
                this.Libros[posicion] = pLibro;
                this.CantidadDeLibtosActuales++;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Encuentra la posicion en la Biblioteca de un libro determinado.
        /// </summary>
        /// <param name="pLibro">Libro que se desea buscar.</param>
        /// <param name="pLibrosBiblioteca">Libros actuales en Biblioteca.</param>
        /// <returns>Devuelve la posicion en la biblioteca del libro.</returns>
        public int PosicionLibro (long pISBN)
        {
            int posicion = 0;
            //Se controla que no se supere la cantidad posible de libros en la biblioteca y que, o la posicion de la biblioteca
            //este vacia o bien no sea el libro que se está buscando.
            while (posicion <= 4 && (this.Libros[posicion] == null || this.Libros[posicion].ISBN != pISBN))
            {
                posicion++;
            }
            return posicion;
        }

        /// <summary>
        /// Controla si un libro existe en Biblioteca.
        /// </summary>
        /// <param name="pISBN">Código ISBN del libro.</param>
        /// <returns></returns>
        public Boolean LibroEnBiblioteca(long pISBN)
        {
            //Si la posicion es mayor que 4 el libro no existe en la biblioteca.
            if (PosicionLibro(pISBN) > 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Da de baja un libro en la Biblioteca.
        /// </summary>
        /// <param name="pLibro">Libro que se desea dar de baja.</param>
        /// <returns>Devuelve true si fue dado de bajo y false si el libro no existe en biblioteca.</returns>
        public Boolean BajaDeLibroEnBiblioteca (long pISBN)
        {
            //Obtiene la posicion del libro que se quiere dar de baja en la biblioteca.
            int posicion = PosicionLibro(pISBN);
            this.Libros[posicion] = null;
            this.CantidadDeLibtosActuales--;
            return true;            
        }

         
    }
}

