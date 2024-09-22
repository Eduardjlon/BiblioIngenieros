using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{
    public class LibroFisico : Libro
    {
        public string Ubicacion { get; set; }

        public LibroFisico(string titulo, string autor, int anioPublicacion, string isbn, string genero, string ubicacion) : base(titulo, autor, anioPublicacion, isbn, genero)
        {
            Ubicacion = ubicacion;
        }
    }

}
