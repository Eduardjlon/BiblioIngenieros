using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{
    public class Biblioteca
    {
        public List<Libro> libros { get; }

        public List<Miembro> miembros { get; }

        public List<Prestamo> prestamos { get; }

        public Biblioteca()
        {
            libros = inicializarLibros();
            miembros = inicializarMiembros();
            prestamos = inicializarPrestamos();
        }

        public List<Libro> inicializarLibros()
        {
            List<Libro> librosActuales = new List<Libro>();
            librosActuales.Add(new LibroFisico("El principito", "Antoine de Saint-Exupéry", 1943, "978-84-206-8539-5", "Fábula", "A-1"));
            librosActuales.Add(new LibroFisico("El señor de los anillos", "J.R.R. Tolkien", 1954, "978-84-450-7379-1", "Fantasía", "A-1"));
            librosActuales.Add(new LibroFisico("Cien años de soledad", "Gabriel García Márquez", 1967, "978-84-376-0494-7", "Realismo mágico", "A-4"));
            librosActuales.Add(new LibroFisico("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "978-84-376-0494-7", "Novela", "A-2"));
            librosActuales.Add(new LibroFisico("La Odisea", "Homero", -800, "978-84-376-0494-7", "Epopeya", "A-3"));
            librosActuales.Add(new LibroFisico("La Iliada", "Homero", -800, "978-84-376-0494-7", "Epopeya", "A-3"));
            librosActuales.Add(new LibroFisico("El retrato de Dorian Gray", "Oscar Wilde", 1890, "978-84-376-0494-7", "Novela", "A-2"));
            librosActuales.Add(new LibroFisico("El amor en los tiempos del cólera", "Gabriel García Márquez", 1985, "978-84-376-0494-7", "Novela", "A-2"));
            librosActuales.Add(new LibroFisico("El Aleph", "Jorge Luis Borges", 1949, "978-84-376-0494-7", "Cuento", "A-4"));
            librosActuales.Add(new LibroFisico("La metamorfosis", "Franz Kafka", 1915, "978-84-376-0494-7", "Novela", "A-2"));
            librosActuales.Add(new LibroElectronico("El principito", "Antoine de Saint-Exupéry", 1943, "978-84-206-8539-5", "Fábula", "PDF", "15MB"));
            librosActuales.Add(new LibroElectronico("El señor de los anillos", "J.R.R. Tolkien", 1954, "978-84-450-7379-1", "Fantasía", "PDF", "20MB"));
            librosActuales.Add(new LibroElectronico("Cien años de soledad", "Gabriel García Márquez", 1967, "978-84-376-0494-7", "Realismo mágico", "PDF", "25MB"));
            librosActuales.Add(new LibroElectronico("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "978-84-376-0494-7", "Novela", "PDF", "30MB"));
            librosActuales.Add(new LibroElectronico("La Odisea", "Homero", -800, "978-84-376-0494-7", "Epopeya", "PDF", "35MB"));
            return librosActuales;
        }

        public List<Miembro> inicializarMiembros()
        {
            List<Miembro> miembrosActuales = new List<Miembro>();
            //Agregar miembros 10 con nombres completos
            miembrosActuales.Add(new Miembro("Juan Perez", 2024001));
            miembrosActuales.Add(new Miembro("Maria Lopez", 2024002));
            miembrosActuales.Add(new Miembro("Pedro Ramirez", 2024003));
            miembrosActuales.Add(new Miembro("Ana Rodriguez", 2023006));
            miembrosActuales.Add(new Miembro("Luisa Martinez", 2023005));
            miembrosActuales.Add(new Miembro("Carlos Sanchez", 2023004));
            miembrosActuales.Add(new Miembro("Sofia Garcia", 2023003));
            miembrosActuales.Add(new Miembro("Jorge Hernandez", 2023002));
            miembrosActuales.Add(new Miembro("Fernanda Torres", 2023001));
            miembrosActuales.Add(new Miembro("Ricardo Chavez", 2022001));
            return miembrosActuales;
        }

        public List<Prestamo> inicializarPrestamos()
        {
            List<Prestamo> prestamosActuales = new List<Prestamo>();
            //Agregar 10 préstamos
            prestamosActuales.Add(new Prestamo(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(7), libros[0], miembros[0]));
            prestamosActuales.Add(new Prestamo(DateTime.Now, DateTime.Now.AddDays(7), libros[1], miembros[1]));
            prestamosActuales.Add(new Prestamo(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(7), libros[2], miembros[2]));
            return prestamosActuales;
        }
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public void EditarLibro(string Id, LibroFisico libroEditado)
        {
            Libro libro = libros.FirstOrDefault(libro => libro.Id == Id);

            if (libro != null)
            {
                EliminarLibro(libro);
                libros.Add(libroEditado);
            }
        }

        public void EditarLibro(string Id, LibroElectronico libroEditado)
        {
            Libro libro = libros.FirstOrDefault(libro => libro.Id == Id);

            if (libro != null)
            {
                EliminarLibro(libro);
                libros.Add(libroEditado);
            }

        }

        public void AgregarMiembro(Miembro miembro)
        {
            miembros.Add(miembro);
        }
        public void EliminarMiembro(Miembro miembro)
        {
            miembros.Remove(miembro);
        }

        public void EditarMiembro(string Id, Miembro miembroEditado)
        {
            Miembro miembroExistente = miembros.FirstOrDefault(m => m.Id == Id);
            if (miembroExistente != null)
            {
                miembroExistente.Nombre = miembroEditado.Nombre;
                miembroExistente.NumeroMiembro = miembroEditado.NumeroMiembro;
            }
        }

        public void RealizarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }
        public void DevolverLibro(Prestamo prestamo)
        {
            prestamos.Remove(prestamo);
        }
    }
}
