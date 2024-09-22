using BibliotecaHerecia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHerecia
{
    public class AppState
    {
        private static AppState instance;
        public Biblioteca bibliotecaActual { get; set; }

        private AppState() {
            bibliotecaActual = new Biblioteca();
        }

        public static AppState Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppState();
                return instance;
            }
        }
    }

}
