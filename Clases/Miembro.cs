using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia.Clases
{

    public class Miembro
    {
        public string Id { get;}
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }

        public Miembro(string nombre, int numeroMiembro)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }
    }
}
