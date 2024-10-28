using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._3
{
    public class Cliente : Persona
    {
        public int Codigo { get; set; }
        public double Limite { get; set; }

        public Cliente() : base()
        {
            Codigo = 0;
            Limite = 0.0;
        }

        public Cliente(int dni, string nombre, string sexo, int codigo, double limite) : base( dni, nombre, sexo)
        {
            Codigo = codigo;
            Limite = limite;
        }

        public override string ToString()
        {
            return $"|DNI: {Dni} |Nombre: {Nombre} |Sexo: {Sexo} |Codigo: {Codigo} |Limite: {Limite}";
        }
    }
}
