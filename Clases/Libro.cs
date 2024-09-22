using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{
    public class Libro
    {
        public string Id { get;}
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }

        public Libro(string titulo, string autor, int anioPublicacion, string isbn, string genero)
        {
            Id = Guid.NewGuid().ToString();
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            ISBN = isbn;
            Genero = genero;
        }

    }
}
