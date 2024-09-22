using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{

    public class LibroElectronico : Libro
    {
        public string Formato { get; set; }
        public string Tamanio { get; set; }

        public LibroElectronico(string titulo, string autor, int anioPublicacion, string isbn, string genero, string formato, string tamanio) : base(titulo, autor, anioPublicacion, isbn, genero)
        {
            Formato = formato;
            Tamanio = tamanio;
        }
    }
}
