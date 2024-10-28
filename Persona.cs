using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._3
{
    public class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }

        public Persona() 
        {
        Dni = 0;
        Nombre = string.Empty;
        Sexo = string.Empty;
        }

        public Persona(int dni, string nombre, string sexo)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Sexo = sexo;
        }
    }
}
