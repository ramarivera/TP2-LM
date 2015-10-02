using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Homogeiniza el acceso a las diferentes operaciones de la Bilbioteca.
    /// </summary>
    class Fachada
    {
        //Crea una nueva instancia de Biblioteca.
        Biblioteca iBiblioteca = new Biblioteca();

        /// <summary>
        /// Verifica si la Bilbioteca ya no tiene más lugar para guardar un libro.
        /// </summary>
        /// <returns>Devuelve true en caso de que este llena y false en caso contrario.</returns>
        public Boolean BibliotecaLlena()
        {
            return iBiblioteca.BibliotecaLlena();
        }

        /// <summary>
        /// Da de alto un libro en la biblioteca.
        /// </summary>
        /// <param name="pISBN">Código ISBN del libro.</param>
        /// <param name="pNombre">Nombre del libro.</param>
        /// <param name="pEditorial">Editorial del libro.</param>
        /// <param name="pAutor">Autor/es del libro.</param>
        /// <param name="pAnio">Año en el que fue editado.</param>
        public void AltaDeLibro (long pISBN, string pNombre, string pEditorial, string pAutor, int pAnio)
        {
            Libro iLibro = new Libro(pISBN, pNombre, pEditorial, pAutor, pAnio);
            iBiblioteca.AltaDeLibroEnBiblioteca(iLibro);
        }

        /// <summary>
        /// Comprueba si existe o no el libro.
        /// </summary>
        /// <param name="pISBN">Código del Libro que se desea buscar.</param>
        /// <returns></returns>
        public Boolean LibroEnBiblioteca (long pISBN)
        {
            return iBiblioteca.LibroEnBiblioteca(pISBN);
        }

        /// <summary>
        /// Recupera la información de un libro determinado.
        /// </summary>
        /// <param name="pISBN">Código ISBN del libro.</param>
        /// <returns>Devuelve la información del libro solicitado.</returns>
        public Libro ObtenerInformaciónLibro(long pISBN)
        {
            int posicion = iBiblioteca.PosicionLibro(pISBN);
            return iBiblioteca.Libros[posicion];
        }

        /// <summary>
        /// Obtiene todos los libros actualmente en biblioteca.
        /// </summary>
        /// <returns>Devuelve los libros en biblioteca.</returns>
        public Libro[] TodosLibrosEnBiblioteca ()
        {
            return iBiblioteca.Libros;
        }

        /// <summary>
        /// Da de baja un libro determinado de la Biblioteca.
        /// </summary>
        /// <param name="pISBN">Código ISBN del libro.</param>
        public void BajaDeLibro(long pISBN)
        {
            iBiblioteca.BajaDeLibroEnBiblioteca(pISBN);
        }
    }
}
