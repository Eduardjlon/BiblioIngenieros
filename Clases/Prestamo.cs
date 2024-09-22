using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{
    public class Prestamo
    {
        public string Id { get; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Libro Libro { get; set; }
        public Miembro Miembro { get; set; }

        public Prestamo(DateTime fechaPrestamo, DateTime fechaDevolucion, Libro libro, Miembro miembro)
        {
            Id = Guid.NewGuid().ToString();
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Libro = libro;
            Miembro = miembro;
        }
       
    }
}
