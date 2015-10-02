using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Poporciona las propiedades y los métodos necesarios para la creación, modificación de un libro.
    /// </summary>
    /// <remarks>Recuerde utilizar esta clase solo cuando sea necesario modificar la información
    /// correspondiente a un libro.</remarks>
    class Libro
    {
        //Atributos
        //Código del libro.
        private long iISBN;
        private string iNombre;
        private string iEditorial;
        private string iAutor;
        //Año en el cual fue editado.
        private int iAnio;

        /// <summary>
        /// Propiedad ISBN del Libro.
        /// </summary>
        public long ISBN
        {
            get { return iISBN; }
            private set { iISBN = value; }
        }

        /// <summary>
        /// Propiedad nombre del Libro.
        /// </summary>
        public string Nombre
        {
            get { return iNombre; }
            private set { iNombre = value; }
        }

        /// <summary>
        /// Propiedad Editorial del Libro.
        /// </summary>
        public string Editorial
        {
            get { return iEditorial; }
            private set { iEditorial = value; }
        }

        /// <summary>
        /// Propiedad autor del Libro.
        /// </summary>
        public string Autor
        {
            get { return iAutor; }
            private set { iAutor = value; }
        }

        /// <summary>
        /// Propiedad año de creación del Libro.
        /// </summary>
        public int Anio
        {
            get { return iAnio; }
            private set { iAnio = value; }
        }

        /// <summary>
        /// Constructor de la clase Libro.
        /// </summary>
        /// <param name="pISBN">Código ISBN del libro.</param>
        /// <param name="pNombre">Nombre del libro.</param>
        /// <param name="pEditorial">Nombre de la editorial del libro.</param>
        /// <param name="pAutor">Nombre/es del autor/es del libro.</param>
        /// <param name="pAnio">Año en el cual el libro fue editado.</param>
        public Libro (long pISBN, string pNombre, string pEditorial, string pAutor, int pAnio)
        {
            this.ISBN = pISBN;
            this.Nombre = pNombre;
            this.Editorial = pEditorial;
            this.Autor = pAutor;
            this.Anio = pAnio;
        }

    }
}
